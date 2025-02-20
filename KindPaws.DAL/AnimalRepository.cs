using KindPaws.Core.DTOs;

namespace KindPaws.DAL;

public class AnimalRepository
{
    public List<AnimalDTO> GetAllAnimals()
    {
        return App.Context.Animals.ToList();
    }

    public List<AnimalDTO> GetAllAnimalsInShelter(int shelterId)
    {
        return App.Context.Animals.Where(x => x.Shelter != null && x.Shelter.Id == shelterId).ToList();
    }
}