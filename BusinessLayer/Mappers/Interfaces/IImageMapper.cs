using BusinessLayer.DTOs.Image;
using Infrastructure.Models;

namespace BusinessLayer.Mappers.Interfaces;

public interface IImageMapper
{
    public ImageDto ToDto(RepositoryImage model);

    public RepositoryImage ToModel(ImageCreateDto dto);

    public RepositoryImage ToModel(ImageDto dto);
}
