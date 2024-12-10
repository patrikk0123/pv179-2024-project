using BusinessLayer.DTOs.Common;
using BusinessLayer.Services.Book.Interfaces;
using Mapster;
using Microsoft.AspNetCore.Mvc;
using WebMVC.ViewModels.Book;

namespace WebMVC.Controllers;

public class BooksController(IBookService bookService) : Controller
{
    [HttpGet("")]
    public async Task<IActionResult> GetAllBooks([FromQuery] Pagination pagination)
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

        var model = bookPage.Adapt<BookPageViewModel>();

        return View(model);
    }
}
