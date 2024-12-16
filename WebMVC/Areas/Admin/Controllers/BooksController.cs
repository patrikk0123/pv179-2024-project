using BusinessLayer.DTOs.Common;
using BusinessLayer.Facades.BookFacades.Interfaces;
using BusinessLayer.Services.Book.Interfaces;
using Mapster;
using Microsoft.AspNetCore.Mvc;
using WebMVC.Areas.Admin.ViewModels.Books;

namespace WebMVC.Areas.Admin.Controllers;

public class BooksController(
    ILogger<BooksController> logger,
    IBookFacade bookFacade,
    IBookService bookService
) : AdminController
{
    public async Task<IActionResult> Index([FromQuery] Pagination pagination)
    {
        var bookPage = await bookService.GetAllBooksAsync(
            pagination,
            null,
            null,
            null,
            null,
            null,
            null
        );

        var model = bookPage.Adapt<BookListPageViewModel>();

        return View(model);
    }

    [HttpGet("admin/books/{id}")]
    public async Task<IActionResult> Detail(int id)
    {
        var book = await bookService.GetSingleBookAsync(id);
        if (book == null)
        {
            return NotFound();
        }

        var model = book.Adapt<BookDetailPageViewModel>();

        return View(model);
    }

    [HttpGet("admin/books/create")]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost("admin/books/create")]
    public async Task<IActionResult> Create(BookViewModel bookViewModel)
    {
        if (!ModelState.IsValid)
        {
            return View(bookViewModel);
        }

        return RedirectToAction("Index");
    }

    [HttpGet("admin/books/update/{id}")]
    public async Task<IActionResult> Update(int id)
    {
        var book = await bookService.GetSingleBookAsync(id);

        if (book == null)
        {
            return NotFound();
        }

        return View();
    }

    [HttpPost("admin/books/update/{id}")]
    public async Task<IActionResult> Update(int id, BookViewModel bookViewModel)
    {
        var book = await bookService.GetSingleBookAsync(id);

        if (book == null)
        {
            return NotFound();
        }

        if (!ModelState.IsValid)
        {
            return View(bookViewModel);
        }

        return RedirectToAction("Index");
    }

    [HttpPost("admin/books/delete/{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var book = await bookService.DeleteBookAsync(id);
        if (book == null)
        {
            return NotFound();
        }

        return RedirectToAction("Index");
    }
}
