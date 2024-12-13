namespace WebMVC.ViewModels.Order;

public class OrderViewModel
{
    public int Id { get; init; }

    public required int UserId { get; init; }

    public required double TotalPrice { get; init; }
}
