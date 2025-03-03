using KindPaws.Core.DTOs;
using Microsoft.EntityFrameworkCore;
using Npgsql;

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
    public UserDto GetUserById(int UserId)
    {
        using (var connection = new NpgsqlConnection(Options.ConnectionString))
        {
            connection.Open();

            string query = UserQueries.GetUserByIdQuery;
            var param = new { Id = UserId };
            UserDto result = connection.QueryFirst<UserDto>(query, param);

            return result;
        }
    }
    public void AddAnimal(AnimalDTO animal)
    {
        using (var connection = new NpgsqlConnection(Options.ConnectionString))
        {
            connection.Open();

            string query = UserQueries.AddUserQuery;
            var param = new
            {
                Name = animal.Name,
                Shelter = animal.Shelter,
                Type = animal.Type,
                Tags = animal.Tags,
                RoleTd = animal.
            };
            connection.Query(query, param);
        }
    }
}