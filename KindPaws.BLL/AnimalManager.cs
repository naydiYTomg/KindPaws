using AutoMapper;
using KindPaws.BLL.MapperProfiles;
using KindPaws.Core.OutputModels;
using KindPaws.DAL;

namespace KindPaws.BLL;

public class AnimalManager
{
    private AnimalRepository _repository = new();
    private Mapper _mapper;

    public AnimalManager()
    {
        var config = new MapperConfiguration(cfg => { cfg.AddProfile(new AnimalMapperProfile()); });
        _mapper = new Mapper(config);
    }

    public async Task<List<AnimalForShelterOutputModel>> GetAllAnimalsInShelterAsync(int shelterId)
    {
        var got = await _repository.GetAllAnimalsInShelterAsync(shelterId);
        var result = _mapper.Map<List<AnimalForShelterOutputModel>>(got);
        return result;
    }
}