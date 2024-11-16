using BusinessLayer.DTOs.Author;
using BusinessLayer.Mappers.Interfaces;
using DAL.Data;
using DAL.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers;

[ApiController]
[Route("/authors")]
public class AuthorController(BookHubDBContext dBContext, IAuthorMapper authorMapper) : Controller
{
    [HttpGet]
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

    [HttpPost]
    public async Task<IActionResult> CreateSingleAuthor([FromBody] AuthorCreateDto authorDto)
    {
        var author = await dBContext.Authors.AddAsync(authorMapper.ToModel(authorDto));
        await dBContext.SaveChangesAsync();

        return CreatedAtAction(
            nameof(GetSingleAuthor),
            new { authorId = author.Entity.Id },
            authorMapper.ToDto(author.Entity)
        );
    }

    [HttpPut]
    [Route("{authorId}")]
    public async Task<IActionResult> UpdateSingleAuthor(
        int authorId,
        [FromBody] AuthorUpdateDto authorDto
    )
    {
        var authorToUpdate = await dBContext.Authors.FindAsync(authorId);
        if (authorToUpdate == null)
        {
            return NotFound();
        }

        authorMapper.UpdateModel(authorToUpdate, authorDto);
        dBContext.Authors.Update(authorToUpdate);
        await dBContext.SaveChangesAsync();

        return Ok(authorMapper.ToDto(authorToUpdate));
    }

    [HttpDelete]
    [Route("{authorId}")]
    public async Task<IActionResult> DeleteSingleAuthor(int authorId)
    {
        var author = await dBContext.Authors.FindAsync(authorId);
        if (author == null)
        {
            return NotFound();
        }

        author.DeletedAt = DateTime.Now;
        await dBContext.SaveChangesAsync();

        return Ok(authorMapper.ToDto(author));
    }
}
