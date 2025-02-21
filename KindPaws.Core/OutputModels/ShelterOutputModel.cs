using KindPaws.Core.DTOs;

namespace KindPaws.Core.OutputModels;

public class ShelterOutputModel
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required UserDTO Owner { get; set; }
    public required string Description { get; set; }
}