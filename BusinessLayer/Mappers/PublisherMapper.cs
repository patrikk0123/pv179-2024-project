using BusinessLayer.DTOs.Book;
using BusinessLayer.DTOs.Publisher;
using BusinessLayer.Mappers.Interfaces;
using DAL.Models;
using Infrastructure.UnitOfWork.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace BusinessLayer.Mappers;

public class PublisherMapper(IServiceProvider serviceProvider) : IPublisherMapper
{
    public PublisherDto ToDto(Publisher publisher)
    {
        return new PublisherDto() { Id = publisher.Id, Name = publisher.Name };
    }

    public PublisherDetailDto ToDetailDto(Publisher publisher)
    {
        using var scope = serviceProvider.CreateScope();
        var unitOfWork = scope.ServiceProvider.GetRequiredService<IImageUnitOfWork>();
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
                    PreviewImage = unitOfWork.ImagePreviewRepository.GetById(book.PreviewImageId),
                })
                .ToList(),
        };
    }

    public Publisher ToModel(PublisherCreateDto dto)
    {
        return new Publisher { Name = dto.Name };
    }

    public void UpdateModel(Publisher publisher, PublisherUpdateDto publisherUpdateDto)
    {
        publisher.Name = publisherUpdateDto.Name;
    }
}
