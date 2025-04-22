using System.ComponentModel.DataAnnotations;
using E_WEST.ViewModels;

namespace E_WEST.ViewModels
{
    public class RegisterViewModel
	{
		[Required(ErrorMessage = "ФИО обязательно")]
		[Display(Name = "ФИО")]
		public string? FullName { get; set; }

		[Required(ErrorMessage = "Email обязателен")]
		[EmailAddress]
		public string? Email { get; set; }

		[Required(ErrorMessage = "Пароль обязателен")]
		[DataType(DataType.Password)]
		public string? Password { get; set; }

		[DataType(DataType.Password)]
		[Compare("Password", ErrorMessage = "Пароли не совпадают")]
		public string? ConfirmPassword { get; set; }

		public string? Phone { get; set; }
		//[Required]
		//public UserRole Role { get; set; }
	}
}