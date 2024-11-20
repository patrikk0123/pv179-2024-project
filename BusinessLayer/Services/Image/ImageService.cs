using BusinessLayer.DTOs.Image;
using BusinessLayer.Mappers.Interfaces;
using BusinessLayer.Services.Image.Interfaces;
using Infrastructure.Helpers;
using Infrastructure.UnitOfWork.Interfaces;

namespace BusinessLayer.Services.Image;

public class ImageService(IImageUnitOfWork imageUnitOfWork, IImageMapper imageMapper)
    : IImageService
{
    public ImageDto CreateImage(ImageCreateDto imageCreateDto, bool save = true)
    {
        try
        {
            imageUnitOfWork.ImageRepository.Add(imageMapper.ToModel(imageCreateDto));

            var previewData = ImageHelpers.CreateImagePreview(imageCreateDto.Data);
            imageCreateDto.Data = previewData;

            imageUnitOfWork.ImagePreviewRepository.Add(imageMapper.ToModel(imageCreateDto));

            if (save)
            {
                imageUnitOfWork.Commit();
            }
        }
        catch (Exception)
        {
            imageUnitOfWork.Rollback();
            throw;
        }

        var image = imageUnitOfWork.ImageRepository.GetById(imageCreateDto.Id);
        return imageMapper.ToDto(image);
    }

    public void DeleteImage(ImageDto imageDto, bool save = true)
    {
        try
        {
            imageUnitOfWork.ImageRepository.Delete(imageMapper.ToModel(imageDto));
            imageUnitOfWork.ImagePreviewRepository.Delete(imageMapper.ToModel(imageDto));
            if (save)
            {
                imageUnitOfWork.Commit();
            }
        }
        catch
        {
            imageUnitOfWork.Rollback();
            throw;
        }
    }

    public ImageDto GetImage(string id)
    {
        var image = imageUnitOfWork.ImageRepository.GetById(id);
        return imageMapper.ToDto(image);
    }

    public ImageDto GetPreviewImage(string id)
    {
        var image = imageUnitOfWork.ImagePreviewRepository.GetById(id);
        return imageMapper.ToDto(image);
    }

    public void Commit()
    {
        imageUnitOfWork.Commit();
    }

    public void Rollback()
    {
        imageUnitOfWork.Rollback();
    }

    public void SaveChanges()
    {
        imageUnitOfWork.SaveChanges();
    }
}
