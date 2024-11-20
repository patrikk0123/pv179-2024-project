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
    public async Task<List<WishListItemDto>> GetAllWishListItems(int userId)
    {
        var wishlistItems = await dBContext
            .WishListItems.Where(item => item.UserId == userId)
            .ToListAsync();

        return wishlistItems.ConvertAll(wishListItemMapper.ToDto);
    }

    public async Task<WishListItemDto?> GetSingleWishlistItemAsync(int wishListItemId)
    {
        var wishListItem = await dBContext.WishListItems.FindAsync(wishListItemId);
        if (wishListItem == null)
        {
            return null;
        }
        return wishListItemMapper.ToDto(wishListItem);
    }

    public async Task<WishListItemDto> CreateWishListItem(int userId, int bookId)
    {
        var wishListItem = await dBContext.WishListItems.AddAsync(
            new WishListItem { UserId = userId, BookId = bookId }
        );

        await SaveAsync(true);

        return wishListItemMapper.ToDto(wishListItem.Entity);
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
