using AutoMapper;
using KindPaws.BLL.MapperProfiles;
using KindPaws.Core.OutputModels;
using KindPaws.DAL;

namespace KindPaws.BLL;

public class ShelterManager
{
    private readonly ShelterRepository _repository = new();
    private readonly Mapper _mapper;


    public ShelterManager()
    {
        var config = new MapperConfiguration(cfg => { cfg.AddProfile(new ShelterMapperProfile()); });
        _mapper = new Mapper(config);
    }

    public async Task<ShelterOutputModel> GetShelterByIdAsync(int id)
    {
        var got = await _repository.GetShelterByIdAsync(id);
        var result = _mapper.Map<ShelterOutputModel>(got);
        return result;
    }
}