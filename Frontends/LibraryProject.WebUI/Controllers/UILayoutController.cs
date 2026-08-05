using Microsoft.AspNetCore.Mvc;

namespace LibraryProject.WebUI.Controllers
{
	public class UILayoutController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
