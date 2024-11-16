using BusinessLayer.DTOs.WishListItem;
using DAL.Models;

namespace BusinessLayer.Mappers.Interfaces;

public interface IWishListItemMapper
    : IEntityMapper<
        WishListItem,
        WishListItemDto,
        WishListItemDetailDto,
        WishListItemCreateDto,
        WishListItemUpdateDto
    >;
