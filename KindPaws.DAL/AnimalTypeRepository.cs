using KindPaws.Core.DTOs;

namespace KindPaws.DAL;

public class AnimalTypeRepository
{

    public List<AnimalTypeDTO> GetAllAnimalTypes()
    {
        using var context = new Context();
        return context.Types.ToList();
    }
}