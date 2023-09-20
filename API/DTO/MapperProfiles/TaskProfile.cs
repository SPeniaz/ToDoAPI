using API.Data.Entities;
using AutoMapper;
using SharedModels.DTO.RequestDtos;
using SharedModels.DTO.ResponseDtos;

namespace API.DTO.MapperProfiles
{
    public class TaskProfile : Profile
    {
        public TaskProfile()
        {
            CreateMap<TaskEntity, TaskReadDto>();
            CreateMap<TaskCreateDto, TaskEntity>();
        }
    }
}
