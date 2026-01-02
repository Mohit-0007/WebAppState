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
            var states = _stateRepo.GetStatesAsync();
            return View(states);
        }

        public IActionResult Details(int id)
        {
            var state = _stateRepo.GetStateByIdAsync(id);
            if (state == null)
            {
                return NotFound();
            }
            return View(state);
        }

        public IActionResult Delete(int id)
        {
            _stateRepo.DeleteStateAsync(id);
            return RedirectToAction("Index");
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(State state)
        {
            if (ModelState.IsValid)
            {
                _stateRepo.CreateStateAsync(state);
                return RedirectToAction("Index");
            }
            return View(state);
        }

        public IActionResult Edit(int id)
        {
            var state = _stateRepo.GetStateByIdAsync(id);
            if (state == null)
            {
                return NotFound();
            }
            return View(state);
        }   
        [HttpPost]
        public IActionResult Edit(State state)
        {
            if (ModelState.IsValid)
            {
                _stateRepo.UpdateStateAsync(state);
                return RedirectToAction("Index");
            }
            return View(state);
        }

        public IActionResult GetByName(string name)
        {
            var state = _stateRepo.GetStateByNameAsync(name);
            if (state == null)
            {
                return NotFound();
            }
            return View("Details", state);
        }

    }
}
