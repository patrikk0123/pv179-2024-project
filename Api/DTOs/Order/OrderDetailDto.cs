using Api.DTOs.OrderItem;

namespace Api.DTOs.Order;

public class OrderDetailDto : OrderDto
{
    public required List<OrderItemDto> OrderItems { get; init; }
}
