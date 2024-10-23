using Api.DTOs.Author;
using Api.DTOs.WishListItem;
using Api.Mappers;
using Api.Mappers.Interfaces;
using DAL.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers;

[ApiController]
[Route("/wishlist")]
public class WishListItemController(
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
        var user = await dBContext.Users.FindAsync(wishListDto.UserId);

        if (user == null)
        {
            return NotFound("User not found");
        }

        var book = await dBContext.Books.FindAsync(wishListDto.BookId);
        if (book == null)
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
    [Route("{wishlistItemId}")]
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
