using Microsoft.AspNetCore.Mvc;

namespace WebMVC.Areas.Admin.Controllers;

public class GenresController(ILogger<GenresController> logger) : AdminController
{
    public IActionResult Index()
    {
        return View();
    }
}
