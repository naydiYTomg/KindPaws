using KindPaws.Core.DTOs;

namespace KindPaws.DAL;

public class NewspaperRepository
{
    public List<NewspaperDTO> GetAllNewspapers()
    {
        return App.Context.Newspapers.ToList();
    }
}