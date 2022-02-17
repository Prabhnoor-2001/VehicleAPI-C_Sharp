using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

public class Bike : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}