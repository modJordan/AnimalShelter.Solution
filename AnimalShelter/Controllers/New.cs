using Microsoft.AspNetCore.Mvc;
using AnimalShelter.Models;
using System.Collections.Generic;
using System.Linq;


namespace AnimalShelter.Controllers
{
  public class NewAnimal : Controller
  {
    private readonly AnimalShelterContext _db;

    public NewAnimal (AnimalShelterContext db)
    {
      _db = db;
    }

    public ActionResult New()
    {
    return View();
    }

    [HttpPost]
    public ActionResult New(string name, string breed, int id, string date, int age)
    {  
    Animal myAnimal = new Animal( name, breed, id, date,  age);
    _db.Animals.Add(myAnimal);
    _db.SaveChanges();
    return RedirectToAction("Index");
    }



  }
}