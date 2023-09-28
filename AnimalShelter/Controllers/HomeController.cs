using Microsoft.AspNetCore.Mvc;


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