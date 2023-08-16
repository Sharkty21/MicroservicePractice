using Microsoft.AspNetCore.Mvc;

namespace CommandsService.Controllers
{
    public class CommandsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
