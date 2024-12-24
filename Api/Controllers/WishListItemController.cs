using BusinessLayer.DTOs.WishListItem;
using BusinessLayer.Services.Book.Interfaces;
using BusinessLayer.Services.User.Interfaces;
using BusinessLayer.Services.WishList.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("/wishlist")]
public class WishListItemController(
    IUserService userService,
    IBookService bookService,
    IWishlistService wishlistService
) : Controller
{
    [HttpGet]
    public async Task<IActionResult> GetAllWishListItems()
    {
        // TODO: get only the wishlist items of the current user
        return Ok(await wishlistService.GetAllWishListItems(1));
    }

    [HttpPost]
    public async Task<IActionResult> CreateWishListItem(
        [FromBody] WishListItemCreateDto wishListDto
    )
    {
        if (!await userService.DoesUserExistAsync(wishListDto.UserId))
        {
            return NotFound("User not found");
        }

        if (!await bookService.DoesBookExistAsync(wishListDto.BookId))
        {
            return NotFound("Book not found");
        }

        var wishListItem = await wishlistService.CreateWishListItem(
            wishListDto.UserId,
            wishListDto.BookId
        );

        return CreatedAtAction(nameof(GetAllWishListItems), wishListItem);
    }

    [HttpDelete]
    [Route("{wishListItemId}")]
    public async Task<IActionResult> DeleteWishListItem(int wishListItemId)
    {
        var deletedWishListItem = await wishlistService.GetSingleWishlistItemAsync(wishListItemId);
        if (deletedWishListItem == null)
        {
            return NotFound("Wish list item not found");
        }

        await wishlistService.DeleteWishListItem(wishListItemId);

        return Ok(deletedWishListItem);
    }
}
