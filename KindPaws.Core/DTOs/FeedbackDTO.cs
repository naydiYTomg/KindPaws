namespace KindPaws.Core.DTOs;

public class FeedbackDTO
{
    public int? Id { get; set; }
    public string? Content { get; set; }
    public int? Value { get; set; }
    public int? UserId { get; set; }
    public int? ShelterId { get; set; }
}