using Microsoft.AspNetCore.Mvc;
using AnimalShelter.Models;
using System.Collections.Generic;
using System.Linq;

namespace AnimalShelter.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}
   
   
   
   
   
    // private readonly AnimalShelterContext _db;

    // public HomeController(AnimalShelterContext db)
    // {
    //   _db = db;
    // }