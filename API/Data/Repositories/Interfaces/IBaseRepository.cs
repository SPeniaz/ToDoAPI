namespace API.Data.Repositories.Interfaces;

public interface IBaseRepository<T>
{
    T? GetById(int id);
    IList<T>? GetAll();
    void Add(T entity);
    void Update(T entity);
    void Delete(int id);
    bool SaveChanges();
}
