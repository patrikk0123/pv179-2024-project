using Microsoft.AspNetCore.Mvc;

namespace WebMVC.Areas.Admin.Controllers;

public class UsersController(ILogger<UsersController> logger) : AdminController
{
    public IActionResult Index()
    {
        return View();
    }
}
