using System.Web.Mvc;
using RazorEngine;

namespace WebApplication472.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			// Here we just call the render method to test
			var html = RazorRendere.Render("Test.Success");

			return View();
		}
	}
}