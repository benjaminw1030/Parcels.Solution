using Microsoft.AspNetCore.Mvc;
using Parcels.Models;
using System.Collections.Generic;

namespace Parcels.Controllers
{
  public class ParcelsController : Controller
  {

    [HttpGet("/parcels/view")]
    public ActionResult ViewParcel()
    {
      Parcel myParcel = Parcel.GetParcel();
      return View(myParcel);
    }

    [HttpGet("/parcels/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/parcels/view")]
    public ActionResult CreateParcel(int height, int width, int length, int weight)
    {
      Parcel myParcel = new Parcel(height, width, length, weight);
      return RedirectToAction("ViewParcel");
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