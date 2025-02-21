using AutoMapper;
using KindPaws.Core.DTOs;
using KindPaws.Core.OutputModels;

namespace KindPaws.BLL.MapperProfiles;

public class FundraiserMapperProfile : Profile
{
    public FundraiserMapperProfile()
    {
        CreateMap<FundraiserDTO, FundraiserOutputModel>();
    }
}