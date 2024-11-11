using System.ComponentModel.DataAnnotations;

namespace Api.DTOs.OrderItem;

public class OrderItemCreateDto
{
    [Required]
    public required int BookId { get; init; }

    [Required]
    public required int Quantity { get; init; }
}
