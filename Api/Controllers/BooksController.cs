using Api.DTOs.Book;
using Api.Mappers.Interfaces;
using DAL.Data;
using DAL.Extensions;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers;

[Route("[controller]")]
public class BooksController : Controller
{
    private readonly BookHubDBContext _dBContext;
    private readonly IEntityMapper<Book, BookDto> _bookMapper;

    public BooksController(BookHubDBContext dBContext, IEntityMapper<Book, BookDto> bookMapper)
    {
        _dBContext = dBContext;
        _bookMapper = bookMapper;
    }

    [HttpGet]
    [Route("/books")]
    public async Task<IActionResult> GetAllBooks(
        [FromQuery] string? name,
        [FromQuery] string? description,
        [FromQuery] double? minPrice,
        [FromQuery] double? maxPrice,
        [FromQuery] string? publisherName,
        [FromQuery] string? genreType
    )
    {
        var books = await _dBContext
            .Books.WhereIf(!string.IsNullOrEmpty(name), book => book.Name.Contains(name))
            .WhereIf(
                !string.IsNullOrEmpty(description),
                book => book.Description.Contains(description)
            )
            .WhereIf(minPrice != null, book => book.Price >= minPrice.Value)
            .WhereIf(maxPrice != null, book => book.Price <= maxPrice.Value)
            .WhereIf(
                !string.IsNullOrEmpty(publisherName),
                book => book.Publisher.Name.Contains(publisherName)
            )
            .WhereIf(
                !string.IsNullOrEmpty(genreType),
                book => book.BookGenres.Any(bookGenre => bookGenre.Genre.GenreType == genreType)
            )
            .Select(book => _bookMapper.ToDto(book))
            .ToListAsync();

        return Ok(books);
    }
}
