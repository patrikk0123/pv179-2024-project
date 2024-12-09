using Microsoft.AspNetCore.Mvc;

namespace WebMVC.Areas.Admin.Controllers;

public class PublishersController(ILogger<PublishersController> logger) : AdminController
{
    public IActionResult Index()
    {
        return View();
    }
}
