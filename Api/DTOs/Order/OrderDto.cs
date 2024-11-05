using Api.DTOs.Interfaces;

namespace Api.DTOs.Order;

public class OrderDto : BaseDto
{
    public required int UserId { get; set; }
    public required double TotalPrice { get; set; }
}
