using KindPaws.Core.DTOs;

namespace KindPaws.Core.OutputModels;

public class UserBasicOutputModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public RoleDTO Role { get; set; }
    public byte[] Password { get; set; }
}