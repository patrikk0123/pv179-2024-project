using BusinessLayer.DTOs.Book;
using BusinessLayer.DTOs.Common;
using BusinessLayer.Facades.BookFacades.Interfaces;
using BusinessLayer.Mappers.Interfaces;
using BusinessLayer.Services.Author.Interfaces;
using BusinessLayer.Services.Book.Interfaces;
using BusinessLayer.Services.Genre.Interfaces;
using BusinessLayer.Services.Publisher.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("/books")]
public class BookController(
    IAuthorService authorService,
    IGenreService genreService,
    IPublisherService publisherService,
    IBookMapper bookMapper,
    IBookService bookService,
    IBookFacade bookFacade
) : Controller
{
    [HttpGet]
    public async Task<IActionResult> GetAllBooks(
        [FromQuery] Pagination pagination,
        [FromQuery] string? name,
        [FromQuery] string? description,
        [FromQuery] double? minPrice,
        [FromQuery] double? maxPrice,
        [FromQuery] string? publisherName,
        [FromQuery] string? genreType
    )
    {
        var books = await bookService.GetAllBooksAsync(
            pagination,
            name,
            description,
            minPrice,
            maxPrice,
            publisherName,
            genreType
        );

        return Ok(books);
    }

    [HttpGet]
    [Route("{bookId}")]
    public async Task<IActionResult> GetSingleBook(int bookId)
    {
        var book = await bookService.GetSingleBookAsync(bookId);
        if (book == null)
        {
            return NotFound();
        }

        return Ok(book);
    }

    [HttpPost]
    public async Task<IActionResult> AddBook([FromForm] BookCreateDto bookDto)
    {
        if (!await publisherService.DoesPublisherExistAsync(bookDto.PublisherId))
        {
            return NotFound();
        }

        if (!await genreService.DoGenresExistAsync(bookDto.GenreIds))
        {
            return NotFound();
        }

        if (!await authorService.DoAuthorsExistAsync(bookDto.AuthorIds))
        {
            return NotFound();
        }

        var finalBook = await bookFacade.CreateBookWithImagesAsync(bookDto);

        return CreatedAtAction(nameof(GetSingleBook), new { bookId = finalBook.Id }, finalBook);
    }

    [HttpPut]
    [Route("{bookId}")]
    public async Task<IActionResult> UpdateBook(int bookId, [FromBody] BookUpdateDto bookDto)
    {
        if (!await bookService.DoesBookExistAsync(bookId))
        {
            return NotFound();
        }

        if (!await publisherService.DoesPublisherExistAsync(bookDto.PublisherId))
        {
            return NotFound();
        }

        if (!await genreService.DoGenresExistAsync(bookDto.GenreIds))
        {
            return NotFound();
        }

        if (!await authorService.DoAuthorsExistAsync(bookDto.AuthorIds))
        {
            return NotFound();
        }

        var updatedBook = await bookService.UpdateBookAsync(bookId, bookDto);

        return Ok(updatedBook);
    }

    [HttpDelete]
    [Route("{bookId}")]
    public async Task<IActionResult> DeleteBook(int bookId)
    {
        if (!await bookService.DoesBookExistAsync(bookId))
        {
            return NotFound();
        }

        var book = await bookService.DeleteBookAsync(bookId);

        return Ok(book);
    }
}
