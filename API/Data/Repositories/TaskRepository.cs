using API.Data.Entities;
using API.Data.Repositories.Interfaces;
using System.Drawing;

namespace API.Data.Repositories;

public class TaskRepository : ITaskRepository
{
    private readonly TasksDbContext _dbContext;
    public TaskRepository(TasksDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public void Add(TaskEntity entity)
    {
        _dbContext.Add(entity);
    }

    public void Delete(int id)
    {
        var entityForDelete = _dbContext.Tasks.Find(id);

        if (entityForDelete != null)
        {
            _dbContext.Tasks.Remove(entityForDelete);
        }
    }

    public IList<TaskEntity>? GetAll()
    {
        return _dbContext.Tasks.ToList();
    }

    public TaskEntity? GetById(int id)
    {
        return _dbContext.Tasks.FirstOrDefault(c => c.Id == id);
    }

    public bool SaveChanges()
    {
        return (_dbContext.SaveChanges() >= 0);
    }

    public void Update(TaskEntity entity)
    {
        var entityForUpdate = _dbContext.Tasks.Find(entity.Id);
        if (entityForUpdate != null)
        {
            _dbContext.Entry(entityForUpdate).CurrentValues.SetValues(entity);
        }
    }
}
