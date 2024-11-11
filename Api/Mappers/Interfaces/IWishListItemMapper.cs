using Api.DTOs.WishListItem;
using DAL.Models;

namespace Api.Mappers.Interfaces;

public interface IWishListItemMapper
    : IEntityMapper<
        WishListItem,
        WishListItemDto,
        WishListItemDetailDto,
        WishListItemCreateDto,
        WishListItemUpdateDto
    >;
