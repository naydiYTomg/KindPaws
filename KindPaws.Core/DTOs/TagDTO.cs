namespace KindPaws.Core.DTOs;

public class TagDTO
{
    public int Id { get; set; }
    public string? Name { get; set; }
    
    public List<AnimalTypeDTO>? Types { get; set; }
    public List<AnimalDTO>? Animals { get; set; }
}