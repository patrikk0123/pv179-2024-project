using BusinessLayer.DTOs.WishListItem;
using BusinessLayer.Mappers.Interfaces;
using BusinessLayer.Services.WishList.Interfaces;
using DAL.Data;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace BusinessLayer.Services.WishList;

public class WishlistService(BookHubDBContext dBContext, IWishListItemMapper wishListItemMapper)
    : BaseService(dBContext),
        IWishlistService
{
    public async Task<List<WishListItemDetailDto>> GetAllWishListItems(int userId)
    {
        var wishlistItems = await dBContext
            .WishListItems.Where(item => item.UserId == userId)
            .ToListAsync();

        return wishlistItems.ConvertAll(wishListItemMapper.ToDetailDto);
    }

    public async Task<WishListItemDetailDto?> GetSingleWishlistItemAsync(int wishListItemId)
    {
        var wishListItem = await dBContext.WishListItems.FindAsync(wishListItemId);
        if (wishListItem == null)
        {
            return null;
        }
        return wishListItemMapper.ToDetailDto(wishListItem);
    }

    public async Task<WishListItemDto> CreateWishListItem(int userId, int bookId)
    {
        var bookInWishList = await dBContext.WishListItems.FirstOrDefaultAsync(wishListItem =>
            wishListItem.UserId == userId && wishListItem.BookId == bookId
        );
        if (bookInWishList is not null)
        {
            return wishListItemMapper.ToDto(bookInWishList);
        }

        var createdWishListItem = await dBContext.WishListItems.AddAsync(
            new WishListItem { UserId = userId, BookId = bookId }
        );

        await SaveAsync(true);

        return wishListItemMapper.ToDto(createdWishListItem.Entity);
    }

    public async Task DeleteWishListItem(int wishListItemId)
    {
        var wishListItem = await dBContext.WishListItems.FindAsync(wishListItemId);
        if (wishListItem == null)
        {
            return;
        }
        dBContext.WishListItems.Remove(wishListItem);
        await SaveAsync(true);
    }
}
