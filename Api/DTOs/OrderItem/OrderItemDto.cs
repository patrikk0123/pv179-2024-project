using Api.DTOs.Book;
using Api.DTOs.Interfaces;

namespace Api.DTOs.OrderItem;

public class OrderItemDto : BaseDto
{
    public required BookDto Book { get; init; }
    public required int Quantity { get; init; }
    public required double Price { get; init; }
}
