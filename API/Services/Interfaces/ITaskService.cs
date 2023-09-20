using API.Data.Entities;
using SharedModels.DTO.RequestDtos;
using SharedModels.DTO.ResponseDtos;

namespace API.Services.Interfaces;

public interface ITaskService : IBaseService<TaskDto,TaskCreateDto>
{
}
