using di0_.Services;
using Microsoft.AspNetCore.Mvc;

namespace di0_.Controllers
{
	public class HomeController : Controller
	{
		private readonly MyMessageInterface _message;
		public HomeController(MyMessageInterface message)
		{
			_message = message;
		}
		[Route("/message")]

		public IActionResult Index()
		{
			string hello = _message.GetMessage();
			return Content(hello);
		}
	}
}
