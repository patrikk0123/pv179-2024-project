using BusinessLayer.DTOs.BookReview;
using BusinessLayer.DTOs.Order;
using BusinessLayer.DTOs.WishListItem;

namespace BusinessLayer.DTOs.User;

public class UserDetailDto : UserDto
{
    public required IEnumerable<BookReviewDto> BookReviews { get; init; } = [];

    public required IEnumerable<OrderDto> Orders { get; init; } = [];

    public required IEnumerable<WishListItemDto> WishListItems { get; init; } = [];
}
