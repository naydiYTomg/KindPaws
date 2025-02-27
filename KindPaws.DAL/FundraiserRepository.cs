using KindPaws.Core.DTOs;
using Microsoft.EntityFrameworkCore;

namespace KindPaws.DAL;

public class FundraiserRepository
{
    public List<FundraiserDTO> GetAllFundraisers()
    {
        using var context = new Context();
        return context.Fundraisers.ToList();
    }


    public async Task<FundraiserDTO> GetCurrentShelterFundraiserByIdAsync(int shelterId)
    {
        await using var context = new Context();
        return await context.Fundraisers.SingleAsync(x => !x.IsEnded && x.Shelter != null && x.Shelter.Id == shelterId);
    }
}