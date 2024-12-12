using BusinessLayer.DTOs.Author;
using BusinessLayer.Services.Author.Interfaces;
using Mapster;
using Microsoft.AspNetCore.Mvc;
using WebMVC.Areas.Admin.ViewModels.Authors;

namespace WebMVC.Areas.Admin.Controllers;

public class AuthorsController(ILogger<AuthorsController> logger, IAuthorService authorService)
    : AdminController
{
    public async Task<IActionResult> Index()
    {
        var authors = await authorService.GetAllAuthorsAsync(null, null);
        var model = new AuthorListPageViewModel
        {
            Authors = authors.ConvertAll(author => author.Adapt<AuthorDetailViewModel>()),
        };
        return View(model);
    }

    [HttpGet("admin/authors/create")]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost("admin/authors/create")]
    public async Task<IActionResult> Create(AuthorFormViewModel model)
    {
        if (ModelState.IsValid)
        {
            var authorDto = model.Adapt<AuthorCreateDto>();
            await authorService.CreateSingleAuthorAsync(authorDto);

            return RedirectToAction("Index");
        }
        return View(model);
    }

    [HttpGet("admin/authors/update/{id}")]
    public async Task<IActionResult> Update(int id)
    {
        var author = await authorService.GetSingleAuthorAsync(id);

        if (author == null)
        {
            return NotFound();
        }

        var model = author.Adapt<AuthorUpdatePageViewModel>();
        return View(model);
    }

    [HttpPost("admin/authors/update/{id}")]
    public async Task<IActionResult> Update(int id, AuthorUpdatePageViewModel model)
    {
        if (ModelState.IsValid)
        {
            var authorDto = model.Adapt<AuthorUpdateDto>();
            await authorService.UpdateSingleAuthorAsync(id, authorDto);

            return RedirectToAction("Index");
        }
        return View(model);
    }

    [HttpGet("admin/authors/delete/{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var author = await authorService.DeleteSingleAuthorAsync(id);

        if (author == null)
        {
            return NotFound();
        }

        return RedirectToAction("Index");
    }
}
