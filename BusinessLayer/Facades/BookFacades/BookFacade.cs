using BusinessLayer.DTOs.Book;
using BusinessLayer.DTOs.Image;
using BusinessLayer.Facades.BookFacades.Interfaces;
using BusinessLayer.Services.Book.Interfaces;
using BusinessLayer.Services.Image.Interfaces;
using Infrastructure.Helpers;
using Microsoft.AspNetCore.Http;

namespace BusinessLayer.Facades.BookFacades;

public class BookFacade(IImageService imageService, IBookService bookService) : IBookFacade
{
    public async Task<string?> AddImageToBookAsync(int bookId, byte[] file)
    {
        string imageId = IdGenerator.GenerateUniqueId();

        imageService.CreateImage(new ImageCreateDto { Id = imageId, Data = file }, save: false);

        var res = await bookService.AddImageToBookAsync(bookId, imageId);

        if (!res)
        {
            imageService.Rollback();
            return null;
        }

        imageService.Commit();

        return imageId;
    }

    public async Task<BookDetailDto> CreateBookWithImagesAsync(
        BookCreateDto bookCreateDto,
        List<IFormFile> images
    )
    {
        List<string> createdImages = [];

        foreach (var image in images)
        {
            string imageId = IdGenerator.GenerateUniqueId();
            createdImages.Add(imageId);

            await using var memoryStream = new MemoryStream();
            image.CopyTo(memoryStream);

            imageService.CreateImage(
                new ImageCreateDto { Id = imageId, Data = memoryStream.ToArray() },
                save: false
            );
        }
        try
        {
            imageService.SaveChanges();
            var book = await bookService.AddBookAsync(bookCreateDto, createdImages);
            imageService.Commit();
            return book;
        }
        catch (Exception)
        {
            imageService.Rollback();
            throw;
        }
    }

    public async Task<bool> DeleteImageFromBooksAsync(string imageId)
    {
        var image = imageService.GetImage(imageId);

        imageService.DeleteImage(image, save: false);

        var res = await bookService.RemoveImageFromBooksAsync(imageId);
        if (!res)
        {
            imageService.Rollback();
            return false;
        }

        imageService.Commit();

        return true;
    }
}
