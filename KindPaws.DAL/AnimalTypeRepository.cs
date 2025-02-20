using KindPaws.Core.DTOs;

namespace KindPaws.DAL;

public class AnimalTypeRepository
{

    public List<AnimalTypeDTO> GetAllAnimalTypes()
    {
        return App.Context.Types.ToList();
    }
}