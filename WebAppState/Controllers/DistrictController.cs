using Microsoft.AspNetCore.Mvc;

namespace WebAppState.Controllers
{
    public class DistrictController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
