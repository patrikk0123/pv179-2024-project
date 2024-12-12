using WebMVC.ViewModels.Book;

namespace WebMVC.ViewModels.WishListItem;

public class WishListItemDetailViewModel
{
    public int Id { get; init; }

    public required int BookId { get; init; }

    public required BookViewModel Book { get; init; }
}
