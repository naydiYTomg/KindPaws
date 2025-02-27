using KindPaws.Core.DTOs;
using Microsoft.EntityFrameworkCore;

namespace KindPaws.DAL;

public class UserRepository
{

    public List<UserDTO> GetAllUsers()
    {
        using var context = new Context();
        return context.Users.ToList();
    }

    public List<UserDTO> GetAllShelterOwners()
    {
        using var context = new Context();
        return context.Users.Where(x => (x.Role != null) && (x.Role.Name == "Владелец приюта")).ToList();
    }

    public UserDTO GetUserById(int id)
    {
        using var context = new Context();
        return context.Users.Single(x => x.Id == id);
    }

    public UserDTO? GetUserByLogin(string login)
    {
        using var context = new Context();
        return context.Users.SingleOrDefault(x => x.Login == login);
    }

    public async Task<UserDTO?> GetUserByLoginAsync(string login)
    {
        await using var context = new Context();
        return await context.Users.SingleOrDefaultAsync(x => x.Login == login);
    }

    public async Task InsertUser(UserDTO user)
    {
        await using var context = new Context();
        await context.Users.AddAsync(user);
        await context.SaveChangesAsync();
    }
}