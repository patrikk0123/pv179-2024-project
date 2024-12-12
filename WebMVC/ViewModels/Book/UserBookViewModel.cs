namespace WebMVC.ViewModels.Book;

public class UserBookViewModel
{
    public required BookDetailViewModel Book { get; init; }

    public required bool IsInUserWishList { get; init; }
}
