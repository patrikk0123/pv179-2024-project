using BusinessLayer.DTOs.Common;

namespace BusinessLayer.DTOs.Order;

public class OrderDto : BaseDto
{
    public required int UserId { get; init; }
    public required double TotalPrice { get; init; }
}
