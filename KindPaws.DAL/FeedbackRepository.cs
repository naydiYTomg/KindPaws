using KindPaws.Core.DTOs;

namespace KindPaws.DAL;

public class FeedbackRepository
{

    public List<FeedbackDTO> GetAllFeedbacks()
    {
        using var context = new Context();
        return context.Feedbacks.ToList();
    }
}