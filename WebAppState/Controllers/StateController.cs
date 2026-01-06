using Microsoft.AspNetCore.Mvc;
using WebAppState.Models;
using WebAppState.Repos.Interfaces;
using WebAppState.Repos;
namespace WebAppState.Controllers
{
    public class StateController : Controller
    {
        private readonly IStates<State> _stateRepo;
        public StateController(IStates<State> stateRepo)
        {
            _stateRepo = stateRepo;
        }
        public async Task<IActionResult> Index()
        {
            var states =await _stateRepo.GetAllAsync();
            return View(states);
        }

        public async Task<IActionResult> Details(int id)
        {
            var state =await _stateRepo.GetByIdAsync(id);
            if (state == null)
            {
                return NotFound();
            }
            return View(state);
        }

        public IActionResult Delete(int id)
        {
            _stateRepo.DeleteAsync(id);
            return RedirectToAction("Index");
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(State state)
        {

            if (ModelState.IsValid)
            {
               await _stateRepo.CreateAsync(state);
                return RedirectToAction("Index");
            }
            return View(state);
        }

        public IActionResult Edit(int id)
        {
            var state = _stateRepo.GetByIdAsync(id);
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
                _stateRepo.UpdateAsync(state);
                return RedirectToAction("Index");
            }
            return View(state);
        }

        public IActionResult GetByName(string name)
        {
            var state = _stateRepo.GetByNameAsync(name);
            if (state == null)
            {
                return NotFound();
            }
            return View("Details", state);
        }

    }
}
