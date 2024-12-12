using BusinessLayer.DTOs.Publisher;
using BusinessLayer.Services.Publisher.Interfaces;
using Mapster;
using Microsoft.AspNetCore.Mvc;
using WebMVC.Areas.Admin.ViewModels.Publisher;

namespace WebMVC.Areas.Admin.Controllers;

public class PublishersController(
    ILogger<PublishersController> logger,
    IPublisherService publisherService
) : AdminController
{
    public async Task<IActionResult> Index()
    {
        var publishers = await publisherService.GetAllPublishersAsync();
        var model = publishers.Adapt<PublisherListPageViewModel>();
        return View(model);
    }

    [HttpGet("admin/publisher/create")]
    public async Task<IActionResult> Create()
    {
        return View();
    }

    [HttpPost("admin/publisher/create")]
    public async Task<IActionResult> Create(PublisherViewModel publisher)
    {
        try
        {
            await publisherService.CreateSinglePublisherAsync(
                new PublisherCreateDto() { Name = publisher.Name }
            );
            return RedirectToAction("Index");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            ModelState.AddModelError(string.Empty, "Something wrong occured.");
        }

        return View();
    }

    [HttpGet("admin/publisher/update/{id}")]
    public async Task<IActionResult> Update(int id)
    {
        var publisher = await publisherService.GetSinglePublisherAsync(id);

        if (publisher == null)
        {
            return NotFound();
        }

        var model = publisher.Adapt<PublisherUpdatePageViewModel>();
        return View(model);
    }

    [HttpPost("admin/publisher/update/{id}")]
    public async Task<IActionResult> Update(int id, PublisherViewModel publisherViewModel)
    {
        var publisher = await publisherService.GetSinglePublisherAsync(id);

        if (publisher == null)
        {
            return NotFound();
        }

        try
        {
            await publisherService.UpdateSinglePublisherAsync(
                id,
                new PublisherUpdateDto() { Name = publisherViewModel.Name }
            );
            return RedirectToAction("Index");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            ModelState.AddModelError(string.Empty, "Something wrong occured.");
        }

        var model = publisher.Adapt<PublisherUpdatePageViewModel>();
        return View(model);
    }

    [HttpGet("admin/publisher/delete/{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var publisher = await publisherService.DeleteSinglePublisherAsync(id);

        if (publisher == null)
        {
            return NotFound();
        }

        return RedirectToAction("Index");
    }
}
