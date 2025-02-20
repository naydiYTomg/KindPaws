using KindPaws.Core.DTOs;

namespace KindPaws.DAL;

public class RoleRepository
{

    public List<RoleDTO> GetAllRoles()
    {
        return App.Context.Roles.ToList();
    }
}