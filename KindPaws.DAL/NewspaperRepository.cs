using KindPaws.Core.DTOs;

namespace KindPaws.DAL;

public class NewspaperRepository
{
    public List<NewspaperDTO> GetAllNewspapers()
    {
        using var context = new Context();
        return context.Newspapers.ToList();
    }
}