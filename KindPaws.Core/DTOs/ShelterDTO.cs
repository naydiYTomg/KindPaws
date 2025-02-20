namespace KindPaws.Core.DTOs;

public class ShelterDTO
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public UserDTO? Owner { get; set; }
    public List<AnimalDTO>? Animals { get; set; }
    
    public List<FeedbackDTO> Feedbacks { get; set; }
}