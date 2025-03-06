using System.ComponentModel.DataAnnotations;

namespace KindPaws.Core.InputModels;

public class UserRegisteringInputModel
{
    [Required(ErrorMessage = "Имя должно быть введено")]
    [StringLength(50, ErrorMessage = "Максимум 50 символов")]
    public string Name { get; set; }
    [Required(ErrorMessage = "Фамилия должна быть введена")]
    [StringLength(50, ErrorMessage = "Максимум 50 символов")]
    public string Surname { get; set; }
    [Required(ErrorMessage = "Логин должен быть введён")]
    [StringLength(50, ErrorMessage = "Максимум 50 символов")]
    public string Login { get; set; }
    public string Password { get; set; }
}