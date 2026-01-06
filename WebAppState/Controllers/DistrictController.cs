using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net.NetworkInformation;
using WebAppState.Models;
using WebAppState.Repos.Interfaces;

namespace WebAppState.Controllers
{
    public class DistrictController : Controller
    {
        private readonly IStates<District> _district;
   

        public DistrictController(IStates<District> states)
        {
            _district = states;
          
        }
        public async Task<IActionResult> Index()
        {
          var result = await _district.GetAllAsync();


            return View(result);
        }
    }
}
