using KindPaws.Core.DTOs;

namespace KindPaws.DAL;

public class ShelterRepository
{
    public List<ShelterDTO> GetAllShelters()
    {
        return App.Context.Shelters.ToList();
    }
}