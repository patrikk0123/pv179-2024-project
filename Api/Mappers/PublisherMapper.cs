using Api.DTOs.Book;
using Api.DTOs.Publisher;
using Api.Mappers.Interfaces;
using DAL.Models;

namespace Api.Mappers;

public class PublisherMapper : IPublisherMapper
{
    public PublisherDto ToDto(Publisher publisher)
    {
        return new PublisherDto() { Id = publisher.Id, Name = publisher.Name };
    }

    public PublisherDetailDto ToDetailDto(Publisher publisher)
    {
        return new PublisherDetailDto()
        {
            Id = publisher.Id,
            Name = publisher.Name,
            Books = publisher
                .Books.Select(book => new BookDto()
                {
                    Id = book.Id,
                    Name = book.Name,
                    ISBN = book.ISBN,
                    Description = book.Description,
                    PublishDate = book.PublishDate,
                    Pages = book.Pages,
                    Rating = book.Rating,
                    Price = book.Price,
                    PublisherName = publisher.Name,
                })
                .ToList(),
        };
    }

    public Publisher ToModel(CreatePublisherDto publisherDto)
    {
        return new Publisher { Name = publisherDto.Name };
    }

    public void UpdateModel(Publisher publisher, UpdatePublisherDto updateDto)
    {
        publisher.Name = updateDto.Name;
    }
}
