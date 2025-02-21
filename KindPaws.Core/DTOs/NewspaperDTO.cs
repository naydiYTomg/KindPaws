namespace KindPaws.Core.DTOs;

public class NewspaperDTO
{
    public int Id { get; set; }
    public string? Content { get; set; }
    public ShelterDTO? Shelter { get; set; }
}