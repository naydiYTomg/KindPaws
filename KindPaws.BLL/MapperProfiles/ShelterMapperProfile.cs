using AutoMapper;
using KindPaws.Core.DTOs;
using KindPaws.Core.OutputModels;

namespace KindPaws.BLL.MapperProfiles;

public class ShelterMapperProfile : Profile
{
    public ShelterMapperProfile()
    {
        CreateMap<ShelterDTO, ShelterOutputModel>();
    }
}