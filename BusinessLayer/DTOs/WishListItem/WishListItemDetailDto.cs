using BusinessLayer.DTOs.Book;

namespace BusinessLayer.DTOs.WishListItem;

public class WishListItemDetailDto : WishListItemDto
{
    public required BookDto Book { get; init; }
}
