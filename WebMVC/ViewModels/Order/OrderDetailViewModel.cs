using WebMVC.ViewModels.OrderItem;

namespace WebMVC.ViewModels.Order;

public class OrderDetailViewModel : OrderViewModel
{
    public required List<OrderItemViewModel> OrderItems { get; init; }
}
