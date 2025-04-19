using Microsoft.AspNetCore.Mvc;

namespace E_WEST.Controllers
{
	public class AccountController : Controller
	{
		public IActionResult Login()
		{
			return View();
		}
		public IActionResult Register()
		{
			return View();
		}
		public IActionResult AdminPanel()
		{
			return View();
		}
	}
}
