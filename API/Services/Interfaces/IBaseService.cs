namespace API.Services.Interfaces;

public interface IBaseService<T, U>
{
    T Get(int id);
    IList<T> GetAll();
    bool Add(U dto);
    bool Update(T dto);
    bool Delete(int id);
}
