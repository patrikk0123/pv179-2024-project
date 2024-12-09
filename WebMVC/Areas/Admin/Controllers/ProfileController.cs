using Microsoft.AspNetCore.Mvc;

namespace WebMVC.Areas.Admin.Controllers;

public class ProfileController(ILogger<ProfileController> logger) : AdminController
{
    public IActionResult Index()
    {
        return View();
    }
}
