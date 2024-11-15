using System.Globalization;
using Api.DTOs.Author;
using Api.DTOs.Book;
using Api.DTOs.BookReview;
using Api.DTOs.Genre;
using Api.Mappers.Interfaces;
using DAL.Models;
using Infrastructure.UnitOfWork.Interfaces;

namespace Api.Mappers;

public class BookMapper(IServiceProvider serviceProvider) : IBookMapper
{
    public BookDto ToDto(Book book)
    {
        using var scope = serviceProvider.CreateScope();
        var unitOfWork = scope.ServiceProvider.GetRequiredService<IImageUnitOfWork>();
        return new BookDto()
        {
            Id = book.Id,
            Name = book.Name,
            ISBN = book.ISBN,
            Description = book.Description,
            PublishDate = book.PublishDate,
            Pages = book.Pages,
            Rating = book.Rating,
            Price = book.Price,
            PublisherName = book.Publisher.Name,
            PreviewImage = unitOfWork.ImagePreviewRepository.GetById(book.PreviewImageId),
        };
    }

    public BookDetailDto ToDetailDto(Book book)
    {
        using var scope = serviceProvider.CreateScope();
        var unitOfWork = scope.ServiceProvider.GetRequiredService<IImageUnitOfWork>();
        return new BookDetailDto()
        {
            Id = book.Id,
            Name = book.Name,
            ISBN = book.ISBN,
            Description = book.Description,
            PublishDate = book.PublishDate,
            Pages = book.Pages,
            Rating = book.Rating,
            Price = book.Price,
            PublisherName = book.Publisher?.Name ?? "",
            Authors = book
                .BookAuthors?.Select(bookAuthor => new AuthorDto()
                {
                    Id = bookAuthor.Author.Id,
                    Name = bookAuthor.Author.Name,
                    Surname = bookAuthor.Author.Surname,
                })
                .ToList(),
            Genres = book
                .BookGenres?.Select(bookGenre => new GenreDto()
                {
                    Id = bookGenre.Genre.Id,
                    GenreType = bookGenre.Genre.GenreType,
                })
                .ToList(),
            Reviews =
                book.Reviews != null
                    ? book
                        .Reviews.Select(review => new BookReviewDto()
                        {
                            Id = review.Id,
                            Rating = review.Rating,
                            Body = review.Body,
                            CreatedAt = review.CreatedAt,
                            ReviewerName = review.User.Username,
                            BookName = book.Name,
                        })
                        .ToList()
                    : [],
            PreviewImage = unitOfWork.ImagePreviewRepository.GetById(book.PreviewImageId),
            Images =
                book.Images?.Select(bookImage =>
                        unitOfWork.ImageRepository.GetById(bookImage.ImageId)!
                    )
                    .ToList() ?? [],
        };
    }

    public Book ToModel(BookCreateDto dto)
    {
        return new Book()
        {
            Name = dto.Name,
            ISBN = dto.ISBN,
            Description = dto.Description,
            PublishDate = DateOnly.Parse(dto.PublishDate, CultureInfo.InvariantCulture),
            Pages = dto.Pages,
            Rating = dto.Rating,
            Price = dto.Price,
            PublisherId = dto.PublisherId,
        };
    }

    public void UpdateModel(Book book, BookUpdateDto dto)
    {
        book.Name = dto.Name;
        book.ISBN = dto.ISBN;
        book.Description = dto.Description;
        book.PublishDate = DateOnly.Parse(dto.PublishDate, CultureInfo.InvariantCulture);
        book.Pages = dto.Pages;
        book.Rating = dto.Rating;
        book.Price = dto.Price;
        book.PublisherId = dto.PublisherId;
    }
}
