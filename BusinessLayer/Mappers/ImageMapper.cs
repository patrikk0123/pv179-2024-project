using BusinessLayer.DTOs.Image;
using BusinessLayer.Mappers.Interfaces;
using Infrastructure.Models;

namespace BusinessLayer.Mappers;

public class ImageMapper : IImageMapper
{
    public ImageDto ToDto(RepositoryImage model)
    {
        return new ImageDto { Id = model.Id, Data = model.Data };
    }

    public RepositoryImage ToModel(ImageCreateDto dto)
    {
        return new RepositoryImage { Id = dto.Id, Data = dto.Data };
    }

    public RepositoryImage ToModel(ImageDto dto)
    {
        return new RepositoryImage { Id = dto.Id, Data = dto.Data };
    }
}
