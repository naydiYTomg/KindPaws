using AutoMapper;
using KindPaws.Core.DTOs;
using KindPaws.Core.OutputModels;

namespace KindPaws.BLL.MapperProfiles;

public class AnimalMapperProfile : Profile
{
    public AnimalMapperProfile()
    {
        CreateMap<AnimalDTO, AnimalForShelterOutputModel>();
    }
}