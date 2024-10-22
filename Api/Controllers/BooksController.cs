using Api.Mappers.Interfaces;
using DAL.Data;
using DAL.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers;

[Route("[controller]")]
public class BooksController(BookHubDBContext dBContext, IBookMapper bookMapper) : Controller
{
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
        var books = await dBContext
            .Books.WhereIf(
                !string.IsNullOrEmpty(name),
                book => EF.Functions.Like(book.Name, $"%{name}%")
            )
            .WhereIf(
                !string.IsNullOrEmpty(description),
                book => EF.Functions.Like(book.Description, $"%{description}%")
            )
            .WhereIf(minPrice != null, book => book.Price >= minPrice.Value)
            .WhereIf(maxPrice != null, book => book.Price <= maxPrice.Value)
            .WhereIf(
                !string.IsNullOrEmpty(publisherName),
                book => EF.Functions.Like(book.Publisher.Name, $"%{publisherName}%")
            )
            .WhereIf(
                !string.IsNullOrEmpty(genreType),
                book =>
                    book.BookGenres.Any(bookGenre =>
                        EF.Functions.Like(bookGenre.Genre.GenreType, $"%{genreType}%")
                    )
            )
            .Select(book => bookMapper.ToDto(book))
            .ToListAsync();

        return Ok(books);
    }

    [HttpGet]
    [Route("/books/{bookId}")]
    public async Task<IActionResult> GetSingleBook(int bookId)
    {
        var book = await dBContext.Books.FindAsync(bookId);
        if (book == null)
        {
            return NotFound();
        }

        return Ok(bookMapper.ToDetailDto(book));
    }
}
