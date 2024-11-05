using Api.DTOs.OrderItem;

namespace Api.DTOs.Order;

public class OrderCreateDto
{
    public List<OrderItemCreateDto> OrderItems { get; set; }
}
