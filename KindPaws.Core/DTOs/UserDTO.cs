namespace KindPaws.Core.DTOs;

public class UserDTO
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public string? Login { get; set; }
    public byte[]? Password { get; set; }
    public RoleDTO? Role { get; set; }
    
    public List<FeedbackDTO> Feedbacks { get; set; }
}