using BusinessLayer.DTOs.WishListItem;
using BusinessLayer.Mappers.Interfaces;
using BusinessLayer.Services.Book.Interfaces;
using BusinessLayer.Services.User.Interfaces;
using DAL.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers;

[ApiController]
[Route("/wishlist")]
public class WishListItemController(
    IUserService userService,
    IBookService bookService,
    BookHubDBContext dBContext,
    IWishListItemMapper wishListItemMapper
) : Controller
{
    // TODO: get only the wishlist items of the current user
    [HttpGet]
    public async Task<IActionResult> GetALlWishListItems()
    {
        var wishlists = await dBContext
            .WishListItems.Select(item => wishListItemMapper.ToDto(item))
            .ToListAsync();

        return Ok(wishlists);
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

        var wishListItem = await dBContext.WishListItems.AddAsync(
            wishListItemMapper.ToModel(wishListDto)
        );
        await dBContext.SaveChangesAsync();

        return CreatedAtAction(
            nameof(GetALlWishListItems),
            wishListItemMapper.ToDto(wishListItem.Entity)
        );
    }

    [HttpDelete]
    [Route("{wishListItemId}")]
    public async Task<IActionResult> DeleteWishListItem(int wishListItemId)
    {
        var wishListItem = await dBContext.WishListItems.FindAsync(wishListItemId);
        if (wishListItem == null)
        {
            return NotFound();
        }

        dBContext.WishListItems.Remove(wishListItem);
        await dBContext.SaveChangesAsync();

        return Ok();
    }
}
