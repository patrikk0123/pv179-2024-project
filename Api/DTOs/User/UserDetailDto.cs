using Api.DTOs.BookReview;
using Api.DTOs.Order;
using Api.DTOs.WishListItem;

namespace Api.DTOs.User;

public class UserDetailDto : UserDto
{
    public required IEnumerable<BookReviewDto> BookReviews { get; init; } = [];

    public required IEnumerable<OrderDto> Orders { get; init; } = [];

    public required IEnumerable<WishListItemDto> WishListItems { get; init; } = [];
}
