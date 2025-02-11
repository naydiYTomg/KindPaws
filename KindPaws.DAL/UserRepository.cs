using Dapper;
using KindPaws.Core.DTOs;
using KindPaws.Core.Queries;
using KindPaws.DAL.Utils;

namespace KindPaws.DAL;

public class UserRepository
{
    public List<UserDTO> GetAllUsers()
    {
        var connection = ConnectionBuilder.Create()
            .WithQuery(UserQueries.GetAllUsers)
            .Build();
        return connection.Execute<UserDTO>().AsList();
    }

    public List<UserDTO> GetAllAdministrators()
    {
        var connection = ConnectionBuilder.Create()
            .WithQuery(UserQueries.GetAllAdministrators)
            .Build();
        return connection.Execute<UserDTO>().AsList();
    }

    public List<UserDTO> GetAllShelterOwners()
    {
        var connection = ConnectionBuilder.Create()
            .WithQuery(UserQueries.GetAllShelterOwners)
            .Build();
        return connection.Execute<UserDTO>().AsList();
    }
}