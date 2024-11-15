namespace Infrastructure.Repository.Interfaces;

public interface IRepository<TEntity>
    where TEntity : class
{
    void Add(TEntity entity);

    void Delete(TEntity entity);

    TEntity? GetById(string id);

    IEnumerable<TEntity> GetAll();

    void SaveChanges();

    void Commit();

    void Rollback();
}
