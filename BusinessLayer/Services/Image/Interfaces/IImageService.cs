using BusinessLayer.DTOs.Image;

namespace BusinessLayer.Services.Image.Interfaces;

public interface IImageService
{
    public ImageDto CreateImage(ImageCreateDto imageCreateDto, bool save = true);

    public ImageDto GetImage(string id);

    public ImageDto GetPreviewImage(string id);

    public void DeleteImage(ImageDto id, bool save = true);

    public void Commit();

    public void Rollback();

    public void SaveChanges();
}
