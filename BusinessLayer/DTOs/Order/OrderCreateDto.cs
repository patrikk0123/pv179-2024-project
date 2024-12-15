using BusinessLayer.DTOs.OrderItem;

namespace BusinessLayer.DTOs.Order;

public class OrderCreateDto
{
    public required List<OrderItemCreateDto> OrderItems { get; init; }

    public required string? CouponCode { get; init; }
}
