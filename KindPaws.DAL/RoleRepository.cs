using KindPaws.Core.DTOs;

namespace KindPaws.DAL;

public class RoleRepository
{

    public List<RoleDTO> GetAllRoles()
    {
        using var context = new Context();
        return context.Roles.ToList();
    }
}