using BusinessLayer.DTOs.Book;
using BusinessLayer.DTOs.Interfaces;

namespace BusinessLayer.DTOs.OrderItem;

public class OrderItemDto : BaseDto
{
    public required BookDto Book { get; init; }
    public required int Quantity { get; init; }
    public required double Price { get; init; }
}
