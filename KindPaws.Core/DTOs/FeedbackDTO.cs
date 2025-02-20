namespace KindPaws.Core.DTOs;

public class FeedbackDTO
{
    public int Id { get; set; }
    public string? Content { get; set; }
    public short Value { get; set; }
    public UserDTO? User { get; set; }
    public ShelterDTO? Shelter { get; set; }
}