namespace KindPaws.Core.InputModels;

public class UserRegisteringInputModel
{
    public required string Name { get; set; }
    public required string Surname { get; set; }
    public required string Login { get; set; }
    public required byte[] Password { get; set; }
}