using Api.DTOs.Publisher;
using DAL.Models;

namespace Api.Mappers.Interfaces;

public interface IPublisherMapper
    : IEntityMapper<
        Publisher,
        PublisherDto,
        PublisherDetailDto,
        PublisherCreateDto,
        PublisherUpdateDto
    >;
