namespace KindPaws.Core.Queries;

public static class UserQueries
{
    public static string GetAllUsers = """
                                        select * from "User"
                                       """;

    public static string GetAllAdministrators = """
                                                 select * from "User" where "IsAdmin"=true
                                                """;
    public static string GetAllShelterOwners = """
                                                 select * from "User" where "IsShelterOwner"=true
                                                """;
}