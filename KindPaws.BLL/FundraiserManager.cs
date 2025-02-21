using AutoMapper;
using KindPaws.BLL.MapperProfiles;
using KindPaws.Core.OutputModels;
using KindPaws.DAL;

namespace KindPaws.BLL;

public class FundraiserManager
{
    private FundraiserRepository _repository = new();
    private Mapper _mapper;

    public FundraiserManager()
    {
        var config = new MapperConfiguration(cfg => { cfg.AddProfile(new FundraiserMapperProfile()); });
        _mapper = new Mapper(config);
    }

    public async Task<FundraiserOutputModel> GetCurrentShelterFundraiserByIdAsync(int shelterId)
    {
        var got = await _repository.GetCurrentShelterFundraiserByIdAsync(shelterId);
        var result = _mapper.Map<FundraiserOutputModel>(got);
        return result;
    }
}