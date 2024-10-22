using Api.DTOs.Genre;
using Api.Mappers.Interfaces;
using DAL.Data;
using DAL.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers;

[ApiController]
[Route("/genres")]
public class GenreController(BookHubDBContext dBContext, IGenreMapper genreMapper) : Controller
{
    [HttpGet]
    [Route("")]
    public async Task<IActionResult> GetAllGenres([FromQuery] string? genreType)
    {
        var genres = await dBContext
            .Genres.WhereIf(
                !string.IsNullOrEmpty(genreType),
                genre => EF.Functions.Like(genre.GenreType, $"%{genreType}%")
            )
            .Select(genre => genreMapper.ToDto(genre))
            .ToListAsync();

        return Ok(genres);
    }

    [HttpGet]
    [Route("{genreId}")]
    public async Task<IActionResult> GetSingleGenre(int genreId)
    {
        var genre = await dBContext.Genres.FindAsync(genreId);
        if (genre == null)
        {
            return NotFound();
        }

        return Ok(genreMapper.ToDetailDto(genre));
    }

    [HttpPost]
    [Route("")]
    public async Task<IActionResult> CreateSingleGenre([FromBody] GenreCreateDto genreCreateDto)
    {
        var genre = await dBContext.Genres.AddAsync(genreMapper.ToModel(genreCreateDto));
        await dBContext.SaveChangesAsync();

        return CreatedAtAction(
            nameof(GetSingleGenre),
            new { genreId = genre.Entity.Id },
            genreMapper.ToDto(genre.Entity)
        );
    }

    [HttpPut]
    [Route("{genreId}")]
    public async Task<IActionResult> UpdateSingleGenre(
        int genreId,
        [FromBody] GenreUpdateDto genreUpdateDto
    )
    {
        var genreToUpdate = await dBContext.Genres.FindAsync(genreId);
        if (genreToUpdate == null)
        {
            return NotFound();
        }

        genreMapper.UpdateModel(genreToUpdate, genreUpdateDto);
        dBContext.Genres.Update(genreToUpdate);
        await dBContext.SaveChangesAsync();

        return Ok(genreMapper.ToDto(genreToUpdate));
    }

    [HttpDelete]
    [Route("{genreId}")]
    public async Task<IActionResult> DeleteSingleGenre(int genreId)
    {
        var genre = await dBContext.Genres.FindAsync(genreId);
        if (genre == null)
        {
            return NotFound();
        }

        genre.DeletedAt = DateTime.Now;
        await dBContext.SaveChangesAsync();

        return Ok(genreMapper.ToDto(genre));
    }
}
