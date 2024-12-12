using BusinessLayer.DTOs.Genre;
using BusinessLayer.Services.Genre.Interfaces;
using Mapster;
using Microsoft.AspNetCore.Mvc;
using WebMVC.Areas.Admin.ViewModels.Genres;

namespace WebMVC.Areas.Admin.Controllers;

public class GenresController(ILogger<GenresController> logger, IGenreService genreService)
    : AdminController
{
    public async Task<IActionResult> Index()
    {
        var genres = await genreService.GetAllGenresAsync(null);
        var model = genres.Adapt<GenreListPageViewModel>();
        return View(model);
    }

    [HttpGet("admin/genres/create")]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost("admin/genres/create")]
    public async Task<IActionResult> Create(GenreFormViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        var genreDto = model.Adapt<GenreCreateDto>();
        await genreService.CreateSingleGenreAsync(genreDto);

        return RedirectToAction("Index");
    }

    [HttpGet("admin/genres/update/{id}")]
    public async Task<IActionResult> Update(int id)
    {
        var genre = await genreService.GetSingleGenreAsync(id);

        if (genre == null)
        {
            return NotFound();
        }

        var model = genre.Adapt<GenreUpdatePageViewModel>();
        return View(model);
    }

    [HttpPost("admin/genres/update/{id}")]
    public async Task<IActionResult> Update(int id, GenreUpdatePageViewModel model)
    {
        if (ModelState.IsValid)
        {
            var genreDto = model.Adapt<GenreUpdateDto>();
            var updatedGenre = await genreService.UpdateSingleGenreAsync(id, genreDto);

            if (updatedGenre == null)
            {
                return NotFound();
            }

            return RedirectToAction("Index");
        }

        return View(model);
    }

    [HttpGet("admin/genres/delete/{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var genre = await genreService.DeleteSingleGenreAsync(id);

        if (genre == null)
        {
            return NotFound();
        }

        return RedirectToAction("Index");
    }
}
