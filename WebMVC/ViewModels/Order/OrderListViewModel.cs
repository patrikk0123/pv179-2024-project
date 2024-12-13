namespace WebMVC.ViewModels.Order;

public class OrderListViewModel
{
    public required List<OrderViewModel> Orders { get; init; } = [];
}
