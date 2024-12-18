using BusinessLayer.DTOs.Order;
using BusinessLayer.Services.GiftCard.Interfaces;
using BusinessLayer.Services.Order.Interfaces;
using DAL.Models.Auth;
using Mapster;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebMVC.ViewModels.Order;

namespace WebMVC.Controllers;

public class CartController(
    UserManager<LocalIdentityUser> userManager,
    IOrderService orderService,
    IGiftCardService giftCardService
) : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    [Authorize]
    public async Task<IActionResult> Index(OrderFormViewModel orderFormViewModel)
    {
        if (!ModelState.IsValid)
        {
            return View(orderFormViewModel);
        }

        var user = await userManager.GetUserAsync(User);

        if (user == null)
        {
            return Unauthorized();
        }

        var order = await orderService.CreateOrderAsync(
            orderFormViewModel.Adapt<OrderCreateDto>(),
            user.UserId
        );

        if (order == null)
        {
            ModelState.AddModelError(string.Empty, "Failed to create order.");
            return View(orderFormViewModel);
        }

        return RedirectToAction(
            nameof(ProfileController.OrderDetail),
            nameof(ProfileController).Replace("Controller", ""),
            new { orderId = order.Id, ClearCart = true }
        );
    }

    [HttpPost("/validate-coupon/{couponCode}")]
    [Authorize]
    public async Task<IActionResult> ValidateCoupon(string couponCode)
    {
        var user = await userManager.GetUserAsync(User);

        if (user == null)
        {
            return Unauthorized();
        }

        var isValid = await giftCardService.CheckCouponIsValidAsync(couponCode);

        if (!isValid)
        {
            return BadRequest("Invalid coupon code.");
        }

        var coupon = await giftCardService.GetCouponAsync(couponCode);

        return Ok(coupon);
    }
}
