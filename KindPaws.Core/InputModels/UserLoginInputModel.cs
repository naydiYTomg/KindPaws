using System.ComponentModel.DataAnnotations;

namespace KindPaws.Core.InputModels;

public class UserLoginInputModel
{
    [Required(ErrorMessage = "Логин должен быть введён")]
    [StringLength(50, ErrorMessage = "Максимум 50 символов")]
    public string Login { get; set; }
    public string Password { get; set; }
}