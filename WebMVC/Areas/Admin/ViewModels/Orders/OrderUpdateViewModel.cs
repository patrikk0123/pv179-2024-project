using DAL.Models;

namespace WebMVC.Areas.Admin.ViewModels.Orders;

public class OrderUpdateViewModel
{
    public required OrderStatus OrderStatus { get; init; }
}
