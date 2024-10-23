using Api.DTOs.Author;
using Api.DTOs.Book;
using Api.DTOs.BookReview;
using Api.DTOs.Genre;
using Api.Mappers.Interfaces;
using DAL.Models;

namespace Api.Mappers;

public class BookMapper : IBookMapper
{
    public BookDto ToDto(Book book)
    {
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
        };
    }

    public BookDetailDto ToDetailDto(Book book)
    {
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
            PublisherName = book.Publisher.Name,
            Authors = book
                .BookAuthors.Select(bookAuthor => new AuthorDto()
                {
                    Name = bookAuthor.Author.Name,
                    Surname = bookAuthor.Author.Surname,
                })
                .ToList(),
            Genres = book
                .BookGenres.Select(bookGenre => new GenreDto()
                {
                    GenreType = bookGenre.Genre.GenreType,
                })
                .ToList(),
            Reviews = book
                .Reviews.Select(review => new BookReviewDto()
                {
                    Id = review.Id,
                    Rating = review.Rating,
                    Body = review.Body,
                    CreatedAt = review.CreatedAt,
                    ReviewerName = review.User.Username,
                    BookName = book.Name,
                })
                .ToList(),
        };
    }

    public Book ToModel(BookCreateDto dto)
    {
        return new Book()
        {
            Name = dto.Name,
            ISBN = dto.ISBN,
            Description = dto.Description,
            PublishDate = new DateOnly(),
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
        book.PublishDate = new DateOnly();
        book.Pages = dto.Pages;
        book.Rating = dto.Rating;
        book.Price = dto.Price;
        book.PublisherId = dto.PublisherId;
    }
}
