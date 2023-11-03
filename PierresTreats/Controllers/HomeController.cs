using Microsoft.AspNetCore.Mvc;
using PierresTreats.Models;
using System.Collections.Generic;
using System.Linq;

namespace PierresTreats.Controllers
{
  public class HomeController : Controller
  {
    private readonly PierresTreatsContext _db;

    public HomeController(PierresTreatsContext db)
    {
      _db = db;
    }

    // [HttpGet("/")]
    // public ActionResult Index()
    // {
    //   Tag[] tags = _db.Tags.ToArray();
    //   Item[] items = _db.Items.ToArray();
    //   Dictionary<string, object[]> model = new Dictionary<string, object[]>();
    //   model.Add("tags", tags);
    //   model.Add("items", items);
    //   return View(model);
    // }
  }
}