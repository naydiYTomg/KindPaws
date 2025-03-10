namespace KindPaws.Core.DTOs;

public class AnimalTypeDTO
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public List<TagDTO>? Tags { get; set; }
}