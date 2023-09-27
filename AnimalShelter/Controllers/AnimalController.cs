using Microsoft.AspNetCore.Mvc;
using AnimalShelter.Models;
using System.Collections.Generic;
using System.Linq;


namespace AnimalShelter.Controllers
{
  public class AnimalController : Controller
  {
    private readonly AnimalShelterContext _db;

    public AnimalController(AnimalShelterContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Animal> model = _db.Animals.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Animal animal)
    {
      _db.Animals.Add(animal);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Animal thisAnimal = _db.Animals.FirstOrDefault(animal => animal.uId == id);
      return View(thisAnimal);
    }

    [HttpGet("/animals/{id}")]
    public ActionResult Show(int id)
    {
      Animal animal = Animal.Find(id);
      return View(animal);
    }
  
  }

 
}


