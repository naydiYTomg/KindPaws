using KindPaws.Core.DTOs;

namespace KindPaws.DAL;

public class UserRepository
{

    public List<UserDTO> GetAllUsers()
    {
        return App.Context.Users.ToList();
    }

    public List<UserDTO> GetAllShelterOwners()
    {
        return App.Context.Users.Where(x => (x.Role != null) && (x.Role.Name == "Владелец приюта")).ToList();
    }

    public UserDTO GetUserById(int id)
    {
        return App.Context.Users.Single(x => x.Id == id);
    }
}