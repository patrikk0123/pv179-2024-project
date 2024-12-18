using WebMVC.ViewModels.Cart;

namespace WebMVC.ViewModels.Order;

public class OrderFormViewModel
{
    public List<CartItemViewModel> OrderItems { get; init; }

    public string? CouponCode { get; init; }
}
