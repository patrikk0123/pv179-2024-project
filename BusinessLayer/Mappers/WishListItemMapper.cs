using BusinessLayer.DTOs.WishListItem;
using BusinessLayer.Mappers.Interfaces;
using DAL.Models;

namespace BusinessLayer.Mappers;

public class WishListItemMapper(IBookMapper bookMapper) : IWishListItemMapper
{
    public WishListItemDto ToDto(WishListItem item)
    {
        return new WishListItemDto()
        {
            Id = item.Id,
            BookId = item.BookId,
            UserId = item.UserId,
        };
    }

    public WishListItemDetailDto ToDetailDto(WishListItem item)
    {
        return new WishListItemDetailDto()
        {
            Id = item.Id,
            BookId = item.BookId,
            UserId = item.UserId,
            Book = bookMapper.ToDetailDto(item.Book),
        };
    }

    public WishListItem ToModel(WishListItemCreateDto dto)
    {
        return new WishListItem() { BookId = dto.BookId, UserId = dto.UserId };
    }

    public void UpdateModel(WishListItem model, WishListItemUpdateDto updateDto) { }
}
