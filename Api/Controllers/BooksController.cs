using DAL.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers;

[Route("[controller]")]
public class BooksController : Controller
{
    private readonly BookHubDBContext _dBContext;

    public BooksController(BookHubDBContext dBContext)
    {
        _dBContext = dBContext;
    }

    [HttpGet]
    [Route("/books")]
    public async Task<IActionResult> GetAllBooks()
    {
        var books = await _dBContext.Books.ToListAsync();

        return Ok(books);
    }
}
