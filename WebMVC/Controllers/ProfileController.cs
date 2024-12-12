using BusinessLayer.Services.WishList.Interfaces;
using DAL.Models.Auth;
using Mapster;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebMVC.ViewModels.WishListItem;

namespace WebMVC.Controllers;

public class ProfileController(
    UserManager<LocalIdentityUser> userManager,
    IWishlistService wishlistService
) : Controller
{
    [HttpGet("/profile/wishlist")]
    [Authorize]
    public async Task<IActionResult> WishList()
    {
        var user = await userManager.GetUserAsync(User);

        var wishListItems = await wishlistService.GetAllWishListItems(user.UserId);

        var model = wishListItems.Adapt<WishListViewModel>();

        return View(model);
    }

    [HttpPost("/profile/wishlist/{bookId}/create")]
    [Authorize]
    public async Task<IActionResult> CreateWishListItem(int bookId)
    {
        var user = await userManager.GetUserAsync(User);

        var wishListItem = await wishlistService.CreateWishListItem(user.UserId, bookId);
        if (wishListItem == null)
        {
            return RedirectToAction(nameof(HomeController.Error), "Home");
        }

        return RedirectToAction(nameof(WishList));
    }

    [HttpPost("/profile/wishlist/{wishListItemId}/delete")]
    [Authorize]
    public async Task<IActionResult> DeleteWishListItem(int wishListItemId)
    {
        var user = await userManager.GetUserAsync(User);

        var wishListItem = await wishlistService.GetSingleWishlistItemAsync(wishListItemId);
        if (wishListItem == null || wishListItem.UserId != user.UserId)
        {
            return RedirectToAction(nameof(HomeController.Error), "Home");
        }

        await wishlistService.DeleteWishListItem(wishListItemId);

        return RedirectToAction(nameof(ProfileController.WishList), "Profile");
    }

    [HttpGet("/profile/orders")]
    public async Task<IActionResult> OrdersList()
    {
        return View();
    }
}
