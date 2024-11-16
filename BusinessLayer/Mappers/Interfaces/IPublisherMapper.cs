using BusinessLayer.DTOs.Publisher;
using DAL.Models;

namespace BusinessLayer.Mappers.Interfaces;

public interface IPublisherMapper
    : IEntityMapper<
        Publisher,
        PublisherDto,
        PublisherDetailDto,
        PublisherCreateDto,
        PublisherUpdateDto
    >;
