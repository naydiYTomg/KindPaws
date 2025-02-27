using KindPaws.Core.DTOs;

namespace KindPaws.DAL;

public class TagRepository
{

    public List<TagDTO> GetAllTags()
    {
        using var context = new Context();
        return context.Tags.ToList();
    }
}