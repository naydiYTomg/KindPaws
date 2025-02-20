using KindPaws.Core.DTOs;

namespace KindPaws.DAL;

public class FeedbackRepository
{

    public List<FeedbackDTO> GetAllFeedbacks()
    {
        return App.Context.Feedbacks.ToList();
    }
}