using System.Runtime.InteropServices;
using System.Text;
using KindPaws.Core.DTOs;

namespace ForTests;

public class Program
{
    public static void Main(string[] args)
    {
        var context = new KindPaws.DAL.Context();

        // var fund = new FundraiserDTO
        // {
        //     Name = "На корм",
        //     Needs = 250000,
        //     Collected = 100000,
        //     IsEnded = false,
        //     Shelter = context.Shelters.First()
        // };
        //
        // context.Fundraisers.Add(fund);

        context.Shelters.First().Description =
            "Мы стараемся защищать собак и помогать им бла бла бла бла бла бла бла бла бла бла бла бла";
        
        context.SaveChanges();
        

        // context.Database.EnsureCreated();
        // var admin = new RoleDTO { Name = "Администратор" };
        // var shelterOwner = new RoleDTO { Name = "Владелец приюта" };
        // context.Roles.AddRange(admin, shelterOwner);
        // context.SaveChanges();
        // var role = new RoleDTO() { Name = "Администратор" };
        // var user = new UserDTO()
        //     { Name = "John", Surname = "Davey Harris", Login = "jdh993", Password = "superstrong"u8.ToArray(), Role = role };
        // context.Roles.Add(role);
        // context.Users.Add(user);
        //
        // context.SaveChanges();
    }
    
}