using Microsoft.AspNetCore.Mvc;

namespace WebMVC.Areas.Admin.Controllers;

public class CouponsController(ILogger<CouponsController> logger) : AdminController
{
    public IActionResult Index()
    {
        return View();
    }
}
