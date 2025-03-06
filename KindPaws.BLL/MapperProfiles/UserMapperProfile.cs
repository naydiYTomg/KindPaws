using System.Security.Cryptography;
using System.Text;
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
        CreateMap<UserRegisteringInputModel, UserDTO>().ForMember(x => x.Password, o => o.MapFrom(c => Shake256.HashData(Encoding.UTF8.GetBytes(c.Password), c.Password.Length)));
        CreateMap<UserDTO, UserBasicOutputModel>();
    }
}