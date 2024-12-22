using BusinessLayer.DTOs.GiftCard;
using BusinessLayer.Services.GiftCard.Interfaces;
using Mapster;
using Microsoft.AspNetCore.Mvc;
using WebMVC.Areas.Admin.ViewModels.GiftCards;

namespace WebMVC.Areas.Admin.Controllers;

public class GiftCardsController(
    ILogger<GiftCardsController> logger,
    IGiftCardService giftCardService
) : AdminController
{
    public async Task<IActionResult> Index()
    {
        var giftCards = await giftCardService.GetAllGiftCardsAsync();
        var model = giftCards.Adapt<GiftCardListPageViewModel>();

        return View(model);
    }

    [HttpGet("admin/giftcards/create")]
    public IActionResult Create()
    {
        return View();
    }

    [HttpGet("admin/giftCards/{giftCardId}")]
    public async Task<IActionResult> Detail(int giftCardId)
    {
        var giftCard = await giftCardService.GetSingleGiftCardAsync(giftCardId);
        if (giftCard == null)
        {
            return NotFound();
        }

        var model = giftCard.Adapt<GiftCardDetailViewModel>();

        return View(model);
    }

    [HttpPost("admin/giftcards/create")]
    public async Task<IActionResult> Create(GiftCardFormViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        var giftCardDto = model.Adapt<GiftCardCreateDto>();
        await giftCardService.CreateSingleGiftCardAsync(giftCardDto);

        return RedirectToAction("Index");
    }

    [HttpGet("admin/giftcards/delete/{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var giftCard = await giftCardService.DeleteSingleGiftCardAsync(id);

        if (giftCard == null)
        {
            return NotFound();
        }

        return RedirectToAction("Index");
    }
}
