using AutoList.Helpers;
using AutoList.Models;
using Microsoft.AspNetCore.Mvc;

namespace AutoList.Controllers
{
    public class AutoController : Controller
    {
        private List<Auto> _autos;

        public AutoController()
        {
            _autos = AutoSeed.Seed();
        }

        public IActionResult Index()
        {
            return View(_autos);
        }

        public IActionResult Details(int id)
        {
            Auto auto = _autos.FirstOrDefault(auto => auto.Id == id)!;

            return View(auto);
        }

        public IActionResult Delete(int id)
        {
            Auto auto = _autos.FirstOrDefault(auto => auto.Id == id)!;

            if (auto != null)
            {
                _autos.Remove(auto);
            }

            return View("Index", _autos);
        }
    }
}
