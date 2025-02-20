namespace KindPaws.Core;

public class Newspaper
{
    public int ShelterId { get; set; }
    public DateTime Date { get; set; }
    public required string Content { get; set; }
}