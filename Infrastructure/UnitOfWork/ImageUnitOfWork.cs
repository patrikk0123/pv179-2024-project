using Infrastructure.Models;
using Infrastructure.Repository;
using Infrastructure.Repository.Interfaces;
using Infrastructure.UnitOfWork.Interfaces;

namespace Infrastructure.UnitOfWork;

public class ImageUnitOfWork(string imageParentPath, string previewImagesParentPath)
    : IImageUnitOfWork
{
    private ImageRepository? _imageRepository;

    private ImageRepository? _imagePreviewRepository;

    public IRepository<RepositoryImage> ImageRepository =>
        _imageRepository ??= new ImageRepository(imageParentPath);

    public IRepository<RepositoryImage> ImagePreviewRepository =>
        _imagePreviewRepository ??= new ImageRepository(previewImagesParentPath);

    public void Commit()
    {
        try
        {
            _imageRepository?.SaveChanges();
            _imagePreviewRepository?.SaveChanges();
        }
        catch (Exception)
        {
            Rollback();
            throw;
        }
        _imageRepository?.Commit();
        _imagePreviewRepository?.Commit();
    }

    public void Rollback()
    {
        _imageRepository?.Rollback();
        _imagePreviewRepository?.Rollback();
    }
}
