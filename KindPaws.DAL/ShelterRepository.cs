using KindPaws.Core.DTOs;
using Microsoft.EntityFrameworkCore;

namespace KindPaws.DAL;

public class ShelterRepository
{
    public List<ShelterDTO> GetAllShelters()
    {
        using var context = new Context();
        return context.Shelters.ToList();
    }

    public async Task<List<ShelterDTO>> GetAllSheltersAsync()
    {
        await using var context = new Context();
        return await context.Shelters.ToListAsync();
    }

    public async Task<ShelterDTO> GetShelterByIdAsync(int id)
    {
        await using var context = new Context();
        return await context.Shelters.SingleAsync(x => x.Id == id);
    }
}