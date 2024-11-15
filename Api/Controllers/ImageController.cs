using DAL.Data;
using DAL.Models;
using Infrastructure.Helpers;
using Infrastructure.Models;
using Infrastructure.UnitOfWork.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("/images")]
public class ImageController(BookHubDBContext dBContext, IImageUnitOfWork unitOfWork) : Controller
{
    [HttpGet]
    public async Task<IActionResult> GetAllImages()
    {
        var images = unitOfWork.ImageRepository.GetAll();
        return Ok(images);
    }

    [HttpGet]
    [Route("{imageId}")]
    public async Task<IActionResult> GetImage(string imageId)
    {
        var image = unitOfWork.ImageRepository.GetById(imageId);
        if (image == null)
        {
            return NotFound();
        }
        return Ok(image);
    }

    [HttpGet]
    [Route("preview/{imageId}")]
    public async Task<IActionResult> GetPreviewImage(string imageId)
    {
        var image = unitOfWork.ImagePreviewRepository.GetById(imageId);
        if (image == null)
        {
            return NotFound();
        }
        return Ok(image);
    }

    [HttpPost]
    public async Task<IActionResult> AddImage(IFormFile file)
    {
        var imageId = AddImageToRepository(file);

        unitOfWork.Commit();

        var image = unitOfWork.ImageRepository.GetById(imageId);

        return CreatedAtAction(nameof(GetImage), new { imageId }, image);
    }

    [HttpPost]
    [Route("{bookId}")]
    public async Task<IActionResult> AddImageToBook(int bookId, IFormFile file)
    {
        string imageId;

        await using var transaction = await dBContext.Database.BeginTransactionAsync();
        try
        {
            imageId = AddImageToRepository(file);
            dBContext.Add(new BookImage { BookId = bookId, ImageId = imageId });

            await dBContext.SaveChangesAsync();
            await transaction.CommitAsync();
            unitOfWork.Commit();
        }
        catch
        {
            transaction.Rollback();
            unitOfWork.Rollback();
            throw;
        }

        var image = unitOfWork.ImageRepository.GetById(imageId);

        return CreatedAtAction(nameof(GetImage), new { imageId }, image);
    }

    [HttpDelete]
    [Route("{imageId}")]
    public async Task<IActionResult> DeleteImage(string imageId)
    {
        var image = unitOfWork.ImageRepository.GetById(imageId);

        if (image == null)
        {
            return NotFound();
        }

        await using var transaction = await dBContext.Database.BeginTransactionAsync();
        try
        {
            var bookImages = dBContext.BookImages.Where(bi => bi.ImageId == imageId);
            dBContext.BookImages.RemoveRange(bookImages);

            unitOfWork.ImageRepository.Delete(image);

            var previewImage = unitOfWork.ImagePreviewRepository.GetById(imageId);

            if (previewImage != null)
            {
                unitOfWork.ImagePreviewRepository.Delete(previewImage);
            }

            await dBContext.SaveChangesAsync();
            await transaction.CommitAsync();
            unitOfWork.Commit();
        }
        catch
        {
            transaction.Rollback();
            unitOfWork.Rollback();
            throw;
        }

        return NoContent();
    }

    private string AddImageToRepository(IFormFile file)
    {
        string imageId = IdGenerator.GenerateUniqueId();

        using (var memoryStream = new MemoryStream())
        {
            file.CopyTo(memoryStream);
            unitOfWork.ImageRepository.Add(
                new RepositoryImage { Id = imageId, Data = memoryStream.ToArray() }
            );

            var previewData = ImageService.CreateImagePreview(memoryStream.ToArray());
            unitOfWork.ImagePreviewRepository.Add(
                new RepositoryImage { Id = imageId, Data = previewData }
            );
        }

        return imageId;
    }
}
