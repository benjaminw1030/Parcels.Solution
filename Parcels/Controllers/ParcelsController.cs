using Microsoft.AspNetCore.Mvc;
using Parcels.Models;
using System.Collections.Generic;

namespace Parcels.Controllers
{
  public class ParcelsController : Controller
  {

    [HttpGet("/parcels")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/parcels/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    // [HttpGet("/cars/budget")]
    // public ActionResult WorthBuyingForm()
    // {
    //   return View();
    // }

  //   [HttpGet("/cars/showcars")]
  //   public ActionResult ShowCars(int budget)
  //   {
  //     List<Car> allCars = Car.GetAll();
  //     List<Car> CarsMatchingSearch = new List <Car>(0);

  //     foreach (Car automobile in allCars)
  //     {
  //       if (automobile.WorthBuying(budget))
  //       {
  //         CarsMatchingSearch.Add(automobile);
  //       }
  //     }
  //     return View(CarsMatchingSearch);
  //   }

  //   [HttpPost("/cars")]
  //   public ActionResult Create(string makeModel, int price, int miles)
  //   {
  //     Car myCar = new Car(makeModel, price, miles);
  //     return RedirectToAction("Index");
  //   }

  //   [HttpPost("/cars/showcars")]
  //   public ActionResult CreateBudget(int budget)
  //   {
  //     return RedirectToAction("ShowCars", new {Budget = budget});
  //   }
  }
}