namespace WebMVC.ViewModels.WishListItem;

public class WishListViewModel
{
    public required List<WishListItemDetailViewModel> WishListItems { get; init; } = [];
}
