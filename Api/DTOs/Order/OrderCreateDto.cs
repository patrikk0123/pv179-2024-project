using Api.DTOs.OrderItem;

namespace Api.DTOs.Order;

public class OrderCreateDto
{
    public required List<OrderItemCreateDto> OrderItems { get; init; }
}
