using Dogs.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dogs.Controllers
{
    public class DogController:Controller
    {
        private readonly DogDbContext dogDbContext;

        public DogController(DogDbContext dogDbContext) 
        {
            this.dogDbContext = dogDbContext;
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        public IActionResult Index()
        {
            var dogs=dogDbContext.Dogs;
            return View(dogs);
        }
        public IActionResult FCI1()
        {
            var dogs = dogDbContext.Dogs;
            return View(dogs);
        }
        public IActionResult FCI2()
        {
            var dogs = dogDbContext.Dogs;
            return View(dogs);
        }
        public IActionResult FCI3()
        {
            var dogs = dogDbContext.Dogs;
            return View(dogs);
        }
        public IActionResult FCI4()
        {
            var dogs = dogDbContext.Dogs;
            return View(dogs);
        }
        public IActionResult FCI5()
        {
            var dogs = dogDbContext.Dogs;
            return View(dogs);
        }
        public IActionResult FCI6()
        {
            var dogs = dogDbContext.Dogs;
            return View(dogs);
        }
        public IActionResult FCI7()
        {
            var dogs = dogDbContext.Dogs;
            return View(dogs);
        }
        public IActionResult FCI8()
        {
            var dogs = dogDbContext.Dogs;
            return View(dogs);
        }
        public IActionResult FCI9()
        {
            var dogs = dogDbContext.Dogs;
            return View(dogs);
        }
        public IActionResult FCI10()
        {
            var dogs = dogDbContext.Dogs;
            return View(dogs);
        }
        public IActionResult FCI0()
        {
            var dogs = dogDbContext.Dogs;
            return View(dogs);
        }
        [HttpPost]
        public async Task<IActionResult> Add(Dog dog)
        {
            if(ModelState.IsValid)
            {
                TempData["status"] = "Добавлена новая порода!";
                await dogDbContext.Dogs.AddAsync(dog);
                await dogDbContext.SaveChangesAsync();  
                return RedirectToAction("Add");
            }
            return View(dog);
            
        }
        public IActionResult Edit()
        {
            return View();
        }
    }
}
