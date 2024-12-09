using Microsoft.AspNetCore.Mvc;

namespace WebMVC.Areas.Admin.Controllers;

public class OrdersController(ILogger<OrdersController> logger) : AdminController
{
    public IActionResult Index()
    {
        return View();
    }
}
