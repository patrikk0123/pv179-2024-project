using System.ComponentModel.DataAnnotations;
using DAL.Models;

namespace BusinessLayer.DTOs.Order;

public class OrderUpdateDto
{
    [Required]
    public required OrderStatus OrderStatus { get; init; }
}
