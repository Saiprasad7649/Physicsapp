using Microsoft.AspNetCore.Mvc;
using PhysicsVSC.Models;

namespace PhysicsVSC.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new KinematicsModel());
        }

        [HttpPost]
        public IActionResult Index(KinematicsModel model)
        {
            if (ModelState.IsValid)
            {
                model.CalculateFinalVelocity();
            }
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
