using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models;

public class Order : BaseEntity
{
    [Required]
    public required OrderStatus OrderStatus { get; set; }

    public double TotalPrice { get; set; }

    public int UserId { get; set; }

    [ForeignKey(nameof(UserId))]
    public virtual User? User { get; set; }

    public virtual IEnumerable<OrderItem>? OrderItems { get; set; }
}
