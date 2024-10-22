using Api.DTOs.Author;
using Api.Mappers.Interfaces;
using DAL.Data;
using DAL.Extensions;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers;

[Route("/authors")]
public class AuthorController(BookHubDBContext dBContext, IAuthorMapper authorMapper) : Controller
{
    [HttpGet]
    [Route("")]
    public async Task<IActionResult> GetALlAuthors(
        [FromQuery] string? name,
        [FromQuery] string? surname
    )
    {
        var authors = await dBContext
            .Authors.WhereIf(
                !string.IsNullOrEmpty(name),
                author => EF.Functions.Like(author.Name, $"%{name}%")
            )
            .WhereIf(
                !string.IsNullOrEmpty(surname),
                author => EF.Functions.Like(author.Surname, $"%{surname}%")
            )
            .Select(book => authorMapper.ToDto(book))
            .ToListAsync();

        return Ok(authors);
    }

    [HttpGet]
    [Route("{authorId}")]
    public async Task<IActionResult> GetSingleAuthor(int authorId)
    {
        var author = await dBContext.Authors.FindAsync(authorId);
        if (author == null)
        {
            return NotFound();
        }

        return Ok(authorMapper.ToDetailDto(author));
    }
}
