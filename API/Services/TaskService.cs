using API.Data.Entities;
using API.Data.Repositories.Interfaces;
using API.Services.Interfaces;
using AutoMapper;
using SharedModels.DTO.RequestDtos;
using SharedModels.DTO.ResponseDtos;

namespace API.Services;

public class TaskService : ITaskService
{
    private readonly ITaskRepository _taskRepository;
    private readonly IMapper _mapper;
    public TaskService(
        ITaskRepository taskRepository,
        IMapper mapper)
    {
        _taskRepository = taskRepository;
        _mapper = mapper;
    }
    public bool Add(TaskCreateDto dto)
    {
        var entityToAdd = _mapper.Map<TaskEntity>(dto);
        _taskRepository.Add(entityToAdd);
        return _taskRepository.SaveChanges();

    }

    public bool Delete(int id)
    {
        _taskRepository.Delete(id);
        return _taskRepository.SaveChanges();
    }

    public TaskDto Get(int id)
    {
        var dbResult = _taskRepository.GetById(id);
        return dbResult == null
            ? new TaskDto()
            : _mapper.Map<TaskDto>(dbResult);
    }

    public IList<TaskDto> GetAll()
    {
        var dbResult = _taskRepository.GetAll();
        return dbResult == null
            ? new List<TaskDto>()
            : _mapper.Map<IList<TaskDto>>(dbResult);
    }

    public bool Update(TaskDto dto)
    {
        var newEntityData = _mapper.Map<TaskEntity>(dto);
        _taskRepository.Update(newEntityData);
        return _taskRepository.SaveChanges();
    }
}
