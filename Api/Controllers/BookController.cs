using Api.DTOs.Book;
using Api.Mappers.Interfaces;
using DAL.Data;
using DAL.Extensions;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers;

[ApiController]
[Route("/books")]
public class BookController(BookHubDBContext dBContext, IBookMapper bookMapper) : Controller
{
    [HttpGet]
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
    [Route("{bookId}")]
    public async Task<IActionResult> GetSingleBook(int bookId)
    {
        var book = await dBContext.Books.FindAsync(bookId);
        if (book == null)
        {
            return NotFound();
        }

        return Ok(bookMapper.ToDetailDto(book));
    }

    [HttpPost]
    public async Task<IActionResult> AddBook([FromBody] BookCreateDto bookDto)
    {
        var publisher = await dBContext.Publishers.FindAsync(bookDto.PublisherId);
        if (publisher == null)
        {
            return NotFound();
        }

        var genres = await dBContext
            .Genres.Where(genre => bookDto.GenreIds.Contains(genre.Id))
            .ToListAsync();
        if (genres.Count != bookDto.GenreIds.Count)
        {
            return NotFound();
        }

        var authors = await dBContext
            .Authors.Where(author => bookDto.AuthorIds.Contains(author.Id))
            .ToListAsync();
        if (authors.Count != bookDto.AuthorIds.Count)
        {
            return NotFound();
        }

        await using var transaction = await dBContext.Database.BeginTransactionAsync();
        try
        {
            var book = dBContext.Books.Add(bookMapper.ToModel(bookDto));
            await dBContext.SaveChangesAsync();

            dBContext.BookGenres.AddRange(
                bookDto.GenreIds.Select(genreId => new BookGenre()
                {
                    BookId = book.Entity.Id,
                    GenreId = genreId,
                })
            );
            dBContext.BookAuthors.AddRange(
                bookDto.AuthorIds.Select(authorId => new BookAuthor()
                {
                    BookId = book.Entity.Id,
                    AuthorId = authorId,
                })
            );
            await dBContext.SaveChangesAsync();

            await transaction.CommitAsync();
            return CreatedAtAction(
                nameof(GetSingleBook),
                new { bookId = book.Entity.Id },
                bookMapper.ToDetailDto(book.Entity)
            );
        }
        catch (Exception e)
        {
            await transaction.RollbackAsync();
            throw;
        }
    }

    [HttpPut]
    [Route("{bookId}")]
    public async Task<IActionResult> UpdateBook(int bookId, [FromBody] BookUpdateDto bookDto)
    {
        var book = await dBContext.Books.FindAsync(bookId);
        if (book == null)
        {
            return NotFound();
        }

        var publisher = await dBContext.Publishers.FindAsync(bookDto.PublisherId);
        if (publisher == null)
        {
            return NotFound();
        }

        var genres = await dBContext
            .Genres.Where(genre => bookDto.GenreIds.Contains(genre.Id))
            .ToListAsync();
        if (genres.Count != bookDto.GenreIds.Count)
        {
            return NotFound();
        }

        var authors = await dBContext
            .Authors.Where(author => bookDto.AuthorIds.Contains(author.Id))
            .ToListAsync();
        if (authors.Count != bookDto.AuthorIds.Count)
        {
            return NotFound();
        }

        await using var transaction = await dBContext.Database.BeginTransactionAsync();
        try
        {
            bookMapper.UpdateModel(book, bookDto);

            dBContext.BookGenres.RemoveRange(
                dBContext.BookGenres.Where(bookGenre => bookGenre.BookId == book.Id)
            );
            dBContext.BookAuthors.RemoveRange(
                dBContext.BookAuthors.Where(bookAuthor => bookAuthor.BookId == book.Id)
            );

            dBContext.BookGenres.AddRange(
                bookDto.GenreIds.Select(genreId => new BookGenre()
                {
                    BookId = book.Id,
                    GenreId = genreId,
                })
            );
            dBContext.BookAuthors.AddRange(
                bookDto.AuthorIds.Select(authorId => new BookAuthor()
                {
                    BookId = book.Id,
                    AuthorId = authorId,
                })
            );
            await dBContext.SaveChangesAsync();

            await transaction.CommitAsync();
            return Ok(bookMapper.ToDetailDto(book));
        }
        catch (Exception)
        {
            await transaction.RollbackAsync();
            throw;
        }
    }

    [HttpDelete]
    [Route("{bookId}")]
    public async Task<IActionResult> DeleteBook(int bookId)
    {
        var book = await dBContext.Books.FindAsync(bookId);
        if (book == null)
        {
            return NotFound();
        }

        await using var transaction = await dBContext.Database.BeginTransactionAsync();
        try
        {
            book.DeletedAt = DateTime.Now;
            await dBContext
                .Reviews.Where(review => review.BookId == bookId)
                .ForEachAsync(review => review.DeletedAt = DateTime.Now);
            await dBContext.SaveChangesAsync();
            await transaction.CommitAsync();
        }
        catch (Exception)
        {
            await transaction.RollbackAsync();
            throw;
        }

        return NoContent();
    }
}
