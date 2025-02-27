using AutoMapper;
using KindPaws.Core.DTOs;
using KindPaws.Core.InputModels;
using KindPaws.Core.OutputModels;

namespace KindPaws.BLL.MapperProfiles;

public class UserMapperProfile : Profile
{
    public UserMapperProfile()
    {
        CreateMap<UserLoginInputModel, UserDTO>();
        CreateMap<UserRegisteringInputModel, UserDTO>();
        CreateMap<UserDTO, UserBasicOutputModel>();
    }
}