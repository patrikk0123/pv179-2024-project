using BusinessLayer.DTOs.Book;
using BusinessLayer.DTOs.Common;
using BusinessLayer.Mappers.Interfaces;
using BusinessLayer.Services.Book.Interfaces;
using DAL.Data;
using DAL.Extensions;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace BusinessLayer.Services.Book;

public class BookService(BookHubDBContext dBContext, IBookMapper bookMapper)
    : BaseService(dBContext),
        IBookService
{
    public async Task<BookPage> GetAllBooksAsync(
        Pagination pagination,
        string? name,
        string? description,
        double? minPrice,
        double? maxPrice,
        string? publisherName,
        string? genreType
    )
    {
        var baseQuery = dBContext
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
            );

        var books = await baseQuery
            .Select(book => bookMapper.ToDto(book))
            .Skip(pagination.PageIndex * pagination.PageSize)
            .Take(pagination.PageSize)
            .ToListAsync();

        var totalCount = await baseQuery.CountAsync();

        var totalPages = (int)Math.Ceiling((double)totalCount / pagination.PageSize);

        var bookPage = new BookPage
        {
            PageIndex = pagination.PageIndex,
            PageSize = pagination.PageSize,
            TotalCount = totalCount,
            TotalPages = totalPages,
            Content = books ?? [],
        };

        return bookPage;
    }

    public async Task<BookDetailDto?> GetSingleBookAsync(int bookId)
    {
        var book = await dBContext.Books.FindAsync(bookId);
        if (book == null)
        {
            return null;
        }

        return bookMapper.ToDetailDto(book);
    }

    public async Task<BookDto?> UpdateBookAsync(int bookId, BookUpdateDto bookDto)
    {
        var book = await dBContext.Books.FindAsync(bookId);
        if (book == null)
        {
            return null;
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
            await SaveAsync(true);

            await transaction.CommitAsync();
        }
        catch (Exception)
        {
            await transaction.RollbackAsync();
            throw;
        }

        return bookMapper.ToDto(book);
    }

    public async Task<BookDetailDto?> DeleteBookAsync(int bookId)
    {
        var book = await dBContext.Books.FindAsync(bookId);
        if (book == null)
        {
            return null;
        }

        await using var transaction = await dBContext.Database.BeginTransactionAsync();
        try
        {
            book.DeletedAt = DateTime.Now;
            await dBContext
                .Reviews.Where(review => review.BookId == bookId)
                .ForEachAsync(review => review.DeletedAt = DateTime.Now);

            await SaveAsync(true);

            await transaction.CommitAsync();
        }
        catch (Exception)
        {
            await transaction.RollbackAsync();
            throw;
        }

        return bookMapper.ToDetailDto(book);
    }

    public async Task<bool> DoBooksExistAsync(IEnumerable<int> bookIds)
    {
        var foundBookCount = await dBContext.Books.CountAsync(book => bookIds.Contains(book.Id));

        return foundBookCount == bookIds.Count();
    }

    public async Task<bool> DoesBookExistAsync(int bookId)
    {
        return await dBContext.Books.AnyAsync(book => book.Id == bookId);
    }

    public async Task<BookDetailDto?> AddBookAsync(BookCreateDto bookDto, List<string> imagesIds)
    {
        await using var transaction = await dBContext.Database.BeginTransactionAsync();
        try
        {
            var book = dBContext.Books.Add(bookMapper.ToModel(bookDto));
            await SaveAsync(true);

            dBContext.BookGenres.AddRange(
                bookDto.GenreIds.Select(genreId => new BookGenre()
                {
                    BookId = book.Entity.Id,
                    Genre = dBContext.Genres.Find(genreId),
                    GenreId = genreId,
                })
            );
            dBContext.BookAuthors.AddRange(
                bookDto.AuthorIds.Select(authorId => new BookAuthor()
                {
                    BookId = book.Entity.Id,
                    AuthorId = authorId,
                    Author = dBContext.Authors.Find(authorId),
                })
            );

            dBContext.AddRange(
                imagesIds.Select(imageId => new BookImage()
                {
                    BookId = book.Entity.Id,
                    ImageId = imageId,
                })
            );

            var finalBook = await dBContext.Books.FindAsync(book.Entity.Id);

            await SaveAsync(true);

            await transaction.CommitAsync();

            return bookMapper.ToDetailDto(finalBook);
        }
        catch (Exception)
        {
            await transaction.RollbackAsync();
            throw;
        }
    }

    public async Task<bool> AddImageToBookAsync(int bookId, string imageId)
    {
        if (!await DoesBookExistAsync(bookId))
        {
            return false;
        }

        dBContext.BookImages.Add(new BookImage() { BookId = bookId, ImageId = imageId });

        await SaveAsync(true);

        return true;
    }

    public async Task<bool> RemoveImageFromBooksAsync(string imageId)
    {
        var bookImage = await dBContext.BookImages.AnyAsync(x => x.ImageId == imageId);
        if (!bookImage)
        {
            return false;
        }

        dBContext.BookImages.RemoveRange(dBContext.BookImages.Where(x => x.ImageId == imageId));

        await SaveAsync(true);

        return true;
    }
}
