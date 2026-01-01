using Microsoft.AspNetCore.Mvc;
using WebAppState.Models;
using WebAppState.Repos.Interfaces;
using WebAppState.Repos;
namespace WebAppState.Controllers
{
    public class StateController : Controller
    {
       private readonly StateRepo _stateRepo;
        public StateController(StateRepo stateRepo)
        {
            _stateRepo = stateRepo;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
