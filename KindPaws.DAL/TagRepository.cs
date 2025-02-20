using KindPaws.Core.DTOs;

namespace KindPaws.DAL;

public class TagRepository
{

    public List<TagDTO> GetAllTags()
    {
        return App.Context.Tags.ToList();
    }
}