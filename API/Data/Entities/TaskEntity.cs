namespace API.Data.Entities;

public class TaskEntity
{
    public int Id { get; set; }
    public string Tittle { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime CreatedDate { get; set; }
    public DateTime DeletedDate { get; set; }
}
