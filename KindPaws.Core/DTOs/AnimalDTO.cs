namespace KindPaws.Core.DTOs;

public class AnimalDTO
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public ShelterDTO? Shelter { get; set; }
    public AnimalTypeDTO? Type { get; set; }
    public List<TagDTO>? Tags { get; set; }
}