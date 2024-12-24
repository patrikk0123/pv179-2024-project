using BusinessLayer.DTOs.Author;
using BusinessLayer.Services.Author.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("/authors")]
public class AuthorController(IAuthorService authorService) : Controller
{
    [HttpGet]
    public async Task<IActionResult> GetAllAuthors(
        [FromQuery] string? name,
        [FromQuery] string? surname
    )
    {
        return Ok(await authorService.GetAllAuthorsAsync(name, surname));
    }

    [HttpGet]
    [Route("{authorId}")]
    public async Task<IActionResult> GetSingleAuthor(int authorId)
    {
        var author = await authorService.GetSingleAuthorAsync(authorId);
        if (author == null)
        {
            return NotFound();
        }

        return Ok(author);
    }

    [HttpPost]
    public async Task<IActionResult> CreateSingleAuthor([FromBody] AuthorCreateDto authorDto)
    {
        var author = await authorService.CreateSingleAuthorAsync(authorDto);
        return CreatedAtAction(nameof(GetSingleAuthor), new { authorId = author.Id }, author);
    }

    [HttpPut]
    [Route("{authorId}")]
    public async Task<IActionResult> UpdateSingleAuthor(
        int authorId,
        [FromBody] AuthorUpdateDto authorDto
    )
    {
        var author = await authorService.UpdateSingleAuthorAsync(authorId, authorDto);
        if (author == null)
        {
            return NotFound();
        }

        return Ok(author);
    }

    [HttpDelete]
    [Route("{authorId}")]
    public async Task<IActionResult> DeleteSingleAuthor(int authorId)
    {
        var deletedAuthor = await authorService.DeleteSingleAuthorAsync(authorId);
        if (deletedAuthor == null)
        {
            return NotFound();
        }

        return Ok(deletedAuthor);
    }
}
