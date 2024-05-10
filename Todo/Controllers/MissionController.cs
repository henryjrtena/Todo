using Microsoft.AspNetCore.Mvc;

namespace Todo.Controllers
{
    public class MissionController : Controller
    {
        public IActionResult Index() => View();
    }
}
