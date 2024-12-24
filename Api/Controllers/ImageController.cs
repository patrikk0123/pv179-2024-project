using BusinessLayer.DTOs.Image;
using BusinessLayer.Facades.BookFacades.Interfaces;
using BusinessLayer.Services.Book.Interfaces;
using BusinessLayer.Services.Image.Interfaces;
using Infrastructure.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("/images")]
public class ImageController(
    IImageService imageService,
    IBookFacade bookFacade,
    IBookService bookService
) : Controller
{
    [HttpGet]
    [Route("{imageId}")]
    public async Task<IActionResult> GetImage(string imageId)
    {
        var image = imageService.GetImage(imageId);
        return Ok(image);
    }

    [HttpGet]
    [Route("preview/{imageId}")]
    public async Task<IActionResult> GetPreviewImage(string imageId)
    {
        var image = imageService.GetPreviewImage(imageId);
        return Ok(image);
    }

    [HttpPost]
    public async Task<IActionResult> AddImage(IFormFile file)
    {
        string imageId = IdGenerator.GenerateUniqueId();
        await using var memoryStream = new MemoryStream();
        file.CopyTo(memoryStream);

        var image = imageService.CreateImage(
            new ImageCreateDto { Id = imageId, Data = memoryStream.ToArray() }
        );

        return CreatedAtAction(nameof(GetImage), new { imageId }, image);
    }

    [HttpPost]
    [Route("{bookId}")]
    public async Task<IActionResult> AddImageToBook(int bookId, IFormFile file)
    {
        if (!await bookService.DoesBookExistAsync(bookId))
        {
            return BadRequest();
        }

        await using var memoryStream = new MemoryStream();
        file.CopyTo(memoryStream);

        var imageId = await bookFacade.AddImageToBookAsync(bookId, memoryStream.ToArray());

        if (imageId == null)
        {
            return BadRequest();
        }

        var image = imageService.GetImage(imageId);

        return CreatedAtAction(nameof(GetImage), new { imageId }, image);
    }

    [HttpDelete]
    [Route("{imageId}")]
    public async Task<IActionResult> DeleteImage(string imageId)
    {
        var res = await bookFacade.DeleteImageFromBooksAsync(imageId);

        if (!res)
        {
            return BadRequest();
        }

        return NoContent();
    }
}
