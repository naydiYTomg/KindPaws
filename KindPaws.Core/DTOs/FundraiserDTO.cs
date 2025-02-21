namespace KindPaws.Core.DTOs;

public class FundraiserDTO
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public decimal Needs { get; set; }
    public decimal Collected { get; set; }
    public bool IsEnded { get; set; }
    public ShelterDTO? Shelter { get; set; }
}