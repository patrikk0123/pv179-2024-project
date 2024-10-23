namespace Api.DTOs.WishListItem;

public class WishListItemCreateDto
{
    public required int UserId { get; init; }

    public required int BookId { get; init; }
}
