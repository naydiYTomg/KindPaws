using KindPaws.Core.DTOs;
using Microsoft.EntityFrameworkCore;

namespace KindPaws.DAL;

public class FundraiserRepository
{
    public List<FundraiserDTO> GetAllFundraisers()
    {
        return App.Context.Fundraisers.ToList();
    }


    public async Task<FundraiserDTO> GetCurrentShelterFundraiserByIdAsync(int shelterId)
    {
        return await App.Context.Fundraisers.SingleAsync(x => !x.IsEnded && x.Shelter != null && x.Shelter.Id == shelterId);
    }
}