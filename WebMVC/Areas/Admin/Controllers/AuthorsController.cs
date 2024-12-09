using Microsoft.AspNetCore.Mvc;

namespace WebMVC.Areas.Admin.Controllers;

public class AuthorsController(ILogger<AuthorsController> logger) : AdminController
{
    public IActionResult Index()
    {
        return View();
    }
}
