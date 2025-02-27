using AutoMapper;
using KindPaws.BLL.MapperProfiles;
using KindPaws.Core.DTOs;
using KindPaws.Core.InputModels;
using KindPaws.Core.OutputModels;
using KindPaws.DAL;

namespace KindPaws.BLL;

public class UserManager
{
    private readonly UserRepository _repository = new();
    private readonly Mapper _mapper;

    public UserManager()
    {
        var config = new MapperConfiguration(cfg => cfg.AddProfile(new UserMapperProfile()));
        _mapper = new Mapper(config);
    }

    public async Task InsertUserRegisterAsync(UserRegisteringInputModel user)
    {
        var dto = _mapper.Map<UserDTO>(user);
        await _repository.InsertUser(dto);
    }

    public async Task<bool> IsLoginFree(string login)
    {
        var got = await _repository.GetUserByLoginAsync(login);
        return got is null;
    }

    public async Task<UserBasicOutputModel?> GetUserByLoginAsync(string login)
    {
        var got = await _repository.GetUserByLoginAsync(login);
        if (got is null) return null;
        var result = _mapper.Map<UserBasicOutputModel>(got);
        return result;
    }
}