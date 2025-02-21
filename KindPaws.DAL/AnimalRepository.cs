using KindPaws.Core.DTOs;
using Microsoft.EntityFrameworkCore;

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

    public async Task<List<AnimalDTO>> GetAllAnimalsInShelterAsync(int shelterId)
    {
        return await App.Context.Animals.Where(x => x.Shelter != null && x.Shelter.Id == shelterId).ToListAsync();
    }
}