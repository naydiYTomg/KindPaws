using KindPaws.Core.DTOs;
using Microsoft.EntityFrameworkCore;

namespace KindPaws.DAL;

public class ShelterRepository
{
    public List<ShelterDTO> GetAllShelters()
    {
        return App.Context.Shelters.ToList();
    }

    public async Task<List<ShelterDTO>> GetAllSheltersAsync()
    {
        return await App.Context.Shelters.ToListAsync();
    }

    public async Task<ShelterDTO> GetShelterByIdAsync(int id)
    {
        return await App.Context.Shelters.SingleAsync(x => x.Id == id);
    }
}