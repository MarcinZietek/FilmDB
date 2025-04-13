
using FilmDB.Models;
using FilmDB.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FilmDB.Controllers
{
    public class FilmController : Controller
    {
        private FilmManager _manager;
        public FilmController(FilmManager manager)
        {
            _manager = manager;
        }    
        public IActionResult Index()
        {
            var films = _manager.GetFilms();
            return View(films);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(FilmModel film)
        {
            _manager.AddFilm(film);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var filmToDelete = _manager.GetFilm(id);
            return View(filmToDelete);          
        }

        [HttpPost]
        public IActionResult Remove(int id)
        {         
            _manager.RemoveFilm(id);
            return RedirectToAction("Index");           
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var filToEdit = _manager.GetFilm(id);
            return View(filToEdit);
        }

        [HttpPost]
        public IActionResult Edit(FilmModel film)
        {
            _manager.UpdateFilm(film);
            return RedirectToAction("Index");
        }
    }
}
