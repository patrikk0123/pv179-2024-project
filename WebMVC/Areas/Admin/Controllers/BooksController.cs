using Microsoft.AspNetCore.Mvc;

namespace WebMVC.Areas.Admin.Controllers;

public class BooksController(ILogger<BooksController> logger) : AdminController
{
    public IActionResult Index()
    {
        return View();
    }
}
