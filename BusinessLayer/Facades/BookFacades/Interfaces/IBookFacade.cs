using BusinessLayer.DTOs.Book;
using Microsoft.AspNetCore.Http;

namespace BusinessLayer.Facades.BookFacades.Interfaces;

public interface IBookFacade
{
    public Task<BookDetailDto> CreateBookWithImagesAsync(
        BookCreateDto bookCreateDto,
        List<IFormFile> images
    );

    public Task<string?> AddImageToBookAsync(int bookId, byte[] file);

    public Task<bool> DeleteImageFromBooksAsync(string imageId);
}
