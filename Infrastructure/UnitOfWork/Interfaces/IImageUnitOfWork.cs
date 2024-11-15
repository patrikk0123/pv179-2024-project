using Infrastructure.Models;
using Infrastructure.Repository.Interfaces;

namespace Infrastructure.UnitOfWork.Interfaces;

public interface IImageUnitOfWork
{
    IRepository<RepositoryImage> ImageRepository { get; }

    IRepository<RepositoryImage> ImagePreviewRepository { get; }

    void Commit();

    void Rollback();
}
