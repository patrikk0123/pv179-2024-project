using Infrastructure.Models;
using Infrastructure.Repository.Interfaces;

namespace Infrastructure.Repository;

public class ImageRepository(string parentPath) : IRepository<RepositoryImage>
{
    private readonly List<RepositoryImage> _addBuffer = [];
    private readonly List<RepositoryImage> _deleteBuffer = [];

    public void Add(RepositoryImage entity)
    {
        if (!_deleteBuffer.Remove(entity))
        {
            _addBuffer.Add(entity);
        }
    }

    public void Delete(RepositoryImage entity)
    {
        if (!_addBuffer.Remove(entity))
        {
            _deleteBuffer.Add(entity);
        }
    }

    public RepositoryImage GetById(string id)
    {
        var persistedImagePath = Directory
            .GetFiles(parentPath)
            .FirstOrDefault(
                filePath => GetImageIdFromFilePath(filePath) == id,
                GetFilePathFromImageId("0")
            );

        var data = File.ReadAllBytes(persistedImagePath);
        return new RepositoryImage { Id = GetImageIdFromFilePath(persistedImagePath), Data = data };
    }

    public IEnumerable<RepositoryImage> GetAll()
    {
        var persistedImages = Directory
            .GetFiles(parentPath)
            .Select(filePath =>
            {
                var data = File.ReadAllBytes(filePath);
                return new RepositoryImage { Id = GetImageIdFromFilePath(filePath), Data = data };
            });

        return persistedImages.Concat(_addBuffer);
    }

    public void SaveChanges()
    {
        foreach (var image in _addBuffer)
        {
            var filePath = GetFilePathFromImageId(image.Id);
            File.WriteAllBytes(filePath, image.Data);
        }
        foreach (var image in _deleteBuffer)
        {
            var filePath = GetFilePathFromImageId(image.Id);
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }
    }

    public void Commit()
    {
        _addBuffer.Clear();
        _deleteBuffer.Clear();
    }

    public void Rollback()
    {
        foreach (var image in _addBuffer)
        {
            var filePath = GetFilePathFromImageId(image.Id);
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }
        foreach (var image in _deleteBuffer)
        {
            var filePath = GetFilePathFromImageId(image.Id);
            File.WriteAllBytes(filePath, image.Data);
        }

        _addBuffer.Clear();
        _deleteBuffer.Clear();
    }

    private static string GetImageIdFromFilePath(string filePath)
    {
        return Path.GetFileNameWithoutExtension(filePath);
    }

    private string GetFilePathFromImageId(string imageId)
    {
        string fileName = $"{imageId}.jpg";
        return Path.Combine(parentPath, fileName);
    }
}
