using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebMVC.ViewModels;

namespace WebMVC.Areas.Admin.Controllers;

public class BooksController(ILogger<BooksController> logger) : AdminController
{
    public IActionResult Index()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(
            new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier }
        );
    }
}
