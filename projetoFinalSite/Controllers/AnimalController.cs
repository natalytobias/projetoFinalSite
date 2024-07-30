using Microsoft.AspNetCore.Mvc;
using projetoFinalSite.Data;
using projetoFinalSite.Models;

namespace projetoFinalSite.Controllers
{
    public class AnimalController : Controller
    {


        readonly private ApplicationDbContext _db;
        public AnimalController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<AnimalModel> animal = _db.Animal;
            return View(animal);
        }


        //inutilizado !!!
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(AnimalModel animal)
        {
            if (ModelState.IsValid)
            {
                _db.Animal.Add(animal);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View();

        }


        public IActionResult Cadastro()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Editar(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }

            AnimalModel animal = _db.Animal.FirstOrDefault(x => x.Id == Id);

            if (animal == null)
            {
                return NotFound();
            }


            return View(animal);
        }


        [HttpPost]
        public IActionResult Editar(AnimalModel animal)
        {
            if (ModelState.IsValid)
            {

                _db.Animal.Update(animal);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(animal);

        }


        [HttpGet]
        public IActionResult Excluir(int? id)
        {

            if (id == null || id == 0)
            {
                return NotFound();
            }


            AnimalModel animal = _db.Animal.FirstOrDefault(x =>x.Id == id);

            if (animal == null)
            {
                return NotFound();
            }
            return View(animal); 
        
        }

        [HttpPost]
        public IActionResult Excluir(AnimalModel animal)
        {
            if (animal == null)
            {
                return NotFound();
            }

            _db.Animal.Remove(animal);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
    
    }
}
