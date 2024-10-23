using Api.DTOs.Book;

namespace Api.DTOs.WishListItem;

public class WishListItemDetailDto : WishListItemDto
{
    public required BookDto Book { get; init; }
}
