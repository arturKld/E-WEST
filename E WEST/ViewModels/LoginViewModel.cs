using System.ComponentModel.DataAnnotations;

namespace E_WEST.ViewModels
{
	public class LoginViewModel
	{
		[Required(ErrorMessage = "Логин обязателен")]
		[Display(Name = "Логин")]
		public string Email { get; set; }  // Можно переименовать в Login, если нужно

		[Required(ErrorMessage = "Пароль обязателен")]
		[DataType(DataType.Password)]
		[Display(Name = "Пароль")]
		public string Password { get; set; }
	}
}
