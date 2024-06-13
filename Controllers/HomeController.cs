using AdminLTEThemePrac.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AdminLTEThemePrac.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public string Page(string file)
		{
			return $"~/Views/Pages/Dashboards/{file}"; 
		}
		public IActionResult Index()
		{
			return View(Page("DashboardV1.cshtml"));
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
