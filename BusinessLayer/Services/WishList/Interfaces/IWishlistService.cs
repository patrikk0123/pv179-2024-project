using BusinessLayer.DTOs.WishListItem;

namespace BusinessLayer.Services.WishList.Interfaces;

public interface IWishlistService
{
    public Task<List<WishListItemDetailDto>> GetAllWishListItems(int userId);

    public Task<WishListItemDetailDto?> GetSingleWishlistItemAsync(int wishListItemId);

    public Task<WishListItemDto> CreateWishListItem(int userId, int bookId);

    public Task DeleteWishListItem(int wishListItemId);
}
