using BusinessLayer.DTOs.Common;
using DAL.Models;

namespace BusinessLayer.DTOs.Order;

public class OrderDto : BaseDto
{
    public required int UserId { get; init; }

    public required string Username { get; init; }

    public required OrderStatus OrderStatus { get; init; }

    public required double TotalPrice { get; init; }
}
