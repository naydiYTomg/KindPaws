using KindPaws.Core.DTOs;
using Microsoft.EntityFrameworkCore;

namespace KindPaws.DAL;

public class AnimalRepository
{
    public List<AnimalDTO> GetAllAnimals()
    {
        using var context = new Context();
        return context.Animals.ToList();
    }

    public List<AnimalDTO> GetAllAnimalsInShelter(int shelterId)
    {
        using var context = new Context();
        return context.Animals.Where(x => x.Shelter != null && x.Shelter.Id == shelterId).ToList();
    }

    public async Task<List<AnimalDTO>> GetAllAnimalsInShelterAsync(int shelterId)
    {
        await using var context = new Context();
        return await context.Animals.Where(x => x.Shelter != null && x.Shelter.Id == shelterId).ToListAsync();
    }
}