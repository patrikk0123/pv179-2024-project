using BusinessLayer.DTOs.Book;
using BusinessLayer.DTOs.Publisher;
using BusinessLayer.Mappers.Interfaces;
using DAL.Models;
using Infrastructure.UnitOfWork.Interfaces;

namespace BusinessLayer.Mappers;

public class PublisherMapper(IImageUnitOfWork unitOfWork, IImageMapper imageMapper)
    : IPublisherMapper
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
                .Books?.Select(book => new BookDto()
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
                    PreviewImage = imageMapper.ToDto(
                        unitOfWork.ImagePreviewRepository.GetById(book.PreviewImageId)
                    ),
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
