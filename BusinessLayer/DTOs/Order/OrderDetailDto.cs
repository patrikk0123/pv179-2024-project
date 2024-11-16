using BusinessLayer.DTOs.OrderItem;

namespace BusinessLayer.DTOs.Order;

public class OrderDetailDto : OrderDto
{
    public required List<OrderItemDto> OrderItems { get; init; }
}
