using WebMVC.ViewModels.Book;

namespace WebMVC.ViewModels.OrderItem;

public class OrderItemViewModel
{
    public required BookViewModel Book { get; init; }

    public required int Quantity { get; init; }

    public required double Price { get; init; }
}
