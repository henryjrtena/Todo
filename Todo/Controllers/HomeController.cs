using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Todo.Classes;
using Todo.Models;

namespace Todo.Controllers
{
    public class HomeController(ILogger<HomeController> logger, HttpHandler http) : Controller
    {
        private readonly ILogger<HomeController> _logger = logger;

        public IActionResult Index() => View();

        public async Task<IActionResult> Privacy()
        {

            var result = await http.GetAsync("https://jsonplaceholder.typicode.com/todos/1");

            ViewBag.Result = result ?? "1";

            return View();
        }

        public IActionResult About() => View();

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
