using Microsoft.AspNetCore.Mvc;

namespace SharedModels.DTO.RequestDtos;

public class TaskCreateDto
{
    [FromQuery(Name = "tittle")]
    public string Tittle { get; set; } = string.Empty;

    [FromQuery(Name = "description")]
    public string Description { get; set; } = string.Empty;
}
