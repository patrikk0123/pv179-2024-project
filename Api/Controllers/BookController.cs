using BusinessLayer.DTOs.Book;
using BusinessLayer.Mappers.Interfaces;
using BusinessLayer.Services.Author.Interfaces;
using BusinessLayer.Services.Genre.Interfaces;
using BusinessLayer.Services.Publisher.Interfaces;
using DAL.Data;
using DAL.Extensions;
using DAL.Models;
using Infrastructure.Helpers;
using Infrastructure.Models;
using Infrastructure.UnitOfWork.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers;

[ApiController]
[Route("/books")]
public class BookController(
    IAuthorService authorService,
    IGenreService genreService,
    IPublisherService publisherService,
    BookHubDBContext dBContext,
    IBookMapper bookMapper,
    IImageUnitOfWork unitOfWork
) : Controller
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

            List<string> createdImages = [];

            foreach (var image in bookDto.Images)
            {
                string imageId = IdGenerator.GenerateUniqueId();
                createdImages.Add(imageId);

                await using var memoryStream = new MemoryStream();
                image.CopyTo(memoryStream);
                unitOfWork.ImageRepository.Add(
                    new RepositoryImage { Id = imageId, Data = memoryStream.ToArray() }
                );

                var previewData = ImageService.CreateImagePreview(memoryStream.ToArray());
                unitOfWork.ImagePreviewRepository.Add(
                    new RepositoryImage { Id = imageId, Data = previewData }
                );
            }

            dBContext.AddRange(
                createdImages.Select(imageId => new BookImage()
                {
                    BookId = book.Entity.Id,
                    ImageId = imageId,
                })
            );

            var finalBook = await dBContext.Books.FindAsync(book.Entity.Id);

            await dBContext.SaveChangesAsync();

            await transaction.CommitAsync();
            unitOfWork.Commit();

            return CreatedAtAction(
                nameof(GetSingleBook),
                new { bookId = book.Entity.Id },
                bookMapper.ToDetailDto(finalBook)
            );
        }
        catch (Exception)
        {
            await transaction.RollbackAsync();
            unitOfWork.Rollback();
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

        await using var transaction = await dBContext.Database.BeginTransactionAsync();
        try
        {
            bookMapper.UpdateModel(book, bookDto);

            if (bookDto.PreviewImageId != null)
            {
                book.PreviewImageId = bookDto.PreviewImageId;
            }

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
