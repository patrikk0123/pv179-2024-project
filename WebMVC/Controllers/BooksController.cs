using BusinessLayer.Services.Book.Interfaces;
using Mapster;
using Microsoft.AspNetCore.Mvc;
using WebMVC.ViewModels.Book;

namespace WebMVC.Controllers;

public class BooksController(IBookService bookService) : Controller
{
    [HttpGet("")]
    public async Task<IActionResult> GetAllBooks()
    {
        var books = await bookService.GetAllBooksAsync(null, null, null, null, null, null);

        var model = books.ConvertAll(book => book.Adapt<BookViewModel>());

        return View(model);
    }
}
