using Api.DTOs.Book;
using Api.DTOs.BookReview;
using Api.DTOs.Order;
using Api.DTOs.WishListItem;

namespace Api.DTOs.User;

public class UserDetailDto : UserDto
{
    public IEnumerable<BookReviewDto> BookReviews { get; init; } = [];

    public IEnumerable<OrderDto> Orders { get; init; } = [];

    public IEnumerable<WishListItemDto> WishListItems { get; init; } = [];
}
