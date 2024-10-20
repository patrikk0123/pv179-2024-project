using Api.DTOs.Book;
using Api.Mappers.Interfaces;
using DAL.Models;

namespace Api.Mappers;

public class BookMapper : IEntityMapper<Book, BookDto>
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

    public Book ToModel(BookDto bookDto)
    {
        return new Book
        {
            Id = bookDto.Id,
            Name = bookDto.Name,
            ISBN = bookDto.ISBN,
            Description = bookDto.Description,
            PublishDate = bookDto.PublishDate,
            Pages = bookDto.Pages,
            Rating = bookDto.Rating,
            Price = bookDto.Price,
        };
    }
}
