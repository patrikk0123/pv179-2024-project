using Api.DTOs.Interfaces;

namespace Api.DTOs.WishListItem;

public class WishListItemDto : BaseDto
{
    public required int UserId { get; init; }

    public required int BookId { get; init; }

    public required string BookName { get; init; }
}
