using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Parcels.Models;

namespace Parcels.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index() { return View(); }

    [HttpGet("/add/new")]
    public ActionResult AddNewShippment() { return View(); }

    [HttpGet("/cart")]
    public ActionResult Cart()
    {
      Location.Price = Parcel.GetPrice();
      List<Parcel> PList = Location.ParcelsList;
      return View(PList);
    }

    [HttpPost("/add")]
    public ActionResult CreateShippment(int width, int height, int length, int weight)
    {
      Parcel newParcel = new Parcel(width, length, height, weight);
      return RedirectToAction("Cart");
    }

    [HttpPost("/delete/parcel")]
    public ActionResult DeleteParcel(string count)
    {
      Location.ParcelsList.RemoveAt(int.Parse(count) - 1);
      return RedirectToAction("Cart");
    }
    [HttpPost("/delete/all")]
    public ActionResult DeleteAllParcels()
    {
      Location.ParcelsList.Clear();
      return RedirectToAction("Cart");
    }

    [HttpGet("/checkout/form")]
    public ActionResult AddLocation() { return View(); }

    [HttpPost("/checkout/add")]
    public ActionResult CreateLocation(int distance, string name)
    {

      // Location newLocation = new Location(distance, name);
      Location.Distance = distance;
      Location.LocationName = name;

      return RedirectToAction("Cart");
    }

  }
}