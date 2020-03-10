using Microsoft.AspNetCore.Mvc;
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
      return View();
    }

    [HttpPost("/add")]
    public ActionResult CreateShippment(int width, int height, int length, int weight)
    {
      Parcel newParcel = new Parcel(width, length, height, weight);
      return RedirectToAction("Index");
    }

    [HttpGet("/checkout/form")]
    public ActionResult AddLocation() { return View(); }

    [HttpPost("/checkout/add")]
    public ActionResult CreateLocation(int distance, string name)
    {
      Location newLocation = new Location(distance, name);
      return RedirectToAction("Cart");
    }

  }
}