using BusinessLayer.DTOs.Genre;
using BusinessLayer.Services.Genre.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("/genres")]
public class GenreController(IGenreService genreService) : Controller
{
    [HttpGet]
    public async Task<IActionResult> GetAllGenres([FromQuery] string? genreType)
    {
        return Ok(await genreService.GetAllGenresAsync(genreType));
    }

    [HttpGet]
    [Route("{genreId}")]
    public async Task<IActionResult> GetSingleGenre(int genreId)
    {
        var genre = await genreService.GetSingleGenreAsync(genreId);
        if (genre == null)
        {
            return NotFound();
        }

        return Ok(genre);
    }

    [HttpPost]
    public async Task<IActionResult> CreateSingleGenre([FromBody] GenreCreateDto genreCreateDto)
    {
        var createdGenre = await genreService.CreateSingleGenreAsync(genreCreateDto);

        return CreatedAtAction(
            nameof(GetSingleGenre),
            new { genreId = createdGenre.Id },
            createdGenre
        );
    }

    [HttpPut]
    [Route("{genreId}")]
    public async Task<IActionResult> UpdateSingleGenre(
        int genreId,
        [FromBody] GenreUpdateDto genreUpdateDto
    )
    {
        var updatedGenre = await genreService.UpdateSingleGenreAsync(genreId, genreUpdateDto);
        if (updatedGenre == null)
        {
            return NotFound();
        }

        return Ok(updatedGenre);
    }

    [HttpDelete]
    [Route("{genreId}")]
    public async Task<IActionResult> DeleteSingleGenre(int genreId)
    {
        var deletedGenre = await genreService.DeleteSingleGenreAsync(genreId);
        if (deletedGenre == null)
        {
            return NotFound();
        }

        return Ok(deletedGenre);
    }
}
