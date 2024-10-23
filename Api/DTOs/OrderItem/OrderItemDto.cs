using Api.DTOs.Book;
using Api.DTOs.Interfaces;

namespace Api.DTOs.OrderItem;

public class OrderItemDto : BaseDto
{
    public required BookDto Book { get; set; }
    public required int Quantity { get; set; }
    public required double Price { get; set; }
}
