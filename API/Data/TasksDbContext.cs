using API.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class TasksDbContext : DbContext
{
    protected readonly IConfiguration Configuration;

    public TasksDbContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseNpgsql(Configuration.GetConnectionString("ToDoDbConnection"));
    }

    public DbSet<TaskEntity> Tasks { get; set; }

}
