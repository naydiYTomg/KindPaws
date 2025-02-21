namespace KindPaws.Core.OutputModels;

public class FundraiserOutputModel
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public decimal Needs { get; set; }
    public decimal Collected { get; set; }
}