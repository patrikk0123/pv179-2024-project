using System.ComponentModel.DataAnnotations;

namespace BusinessLayer.DTOs.OrderItem;

public class OrderItemCreateDto
{
    [Required]
    public required int BookId { get; init; }

    [Required]
    public required int Quantity { get; init; }
}
