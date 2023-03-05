using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers
{
    public class PeopleController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}