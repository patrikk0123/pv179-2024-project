using BusinessLayer.DTOs.Common;

namespace BusinessLayer.DTOs.WishListItem;

public class WishListItemDto : BaseDto
{
    public required int UserId { get; init; }

    public required int BookId { get; init; }
}
