using System.ComponentModel.DataAnnotations;

namespace KindPaws.Core.InputModels;

public class FeedbackInputModel
{
    [Required(ErrorMessage = "Текст отзыва обязателен")]
    [StringLength(2000, ErrorMessage = "Максимум 2000 символов")]
    public string Content { get; set; }
    [Required(ErrorMessage = "Укажите оценку")]
    [Range(1, 5, ErrorMessage = "Оценка должна быть от 1 до 5")]
    public int Rating { get; set; }
    [Required(ErrorMessage = "Укажите своё имя")]
    [StringLength(50, ErrorMessage = "Максимум 50 символов")]
    public string AuthorName { get; set; }
    [Required(ErrorMessage = "Укажите свою фамилию")]
    [StringLength(50, ErrorMessage = "Максимум 50 символов")]
    public string AuthorSurname { get; set; }
    
    public int ShelterId { get; set; }
}