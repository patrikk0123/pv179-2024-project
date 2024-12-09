using Microsoft.AspNetCore.Mvc;

namespace WebMVC.Areas.Admin.Controllers;

public class HomeController(ILogger<HomeController> logger) : AdminController
{
    public IActionResult Index()
    {
        return View();
    }
}
