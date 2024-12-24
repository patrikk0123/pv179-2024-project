using BusinessLayer.DTOs.WishListItem;

namespace BusinessLayer.Services.WishList.Interfaces;

public interface IWishlistService
{
    public Task<List<WishListItemDto>> GetAllWishListItems(int userId);

    public Task<WishListItemDto?> GetSingleWishlistItemAsync(int wishListItemId);

    public Task<WishListItemDto> CreateWishListItem(int userId, int bookId);

    public Task DeleteWishListItem(int wishListItemId);
}
