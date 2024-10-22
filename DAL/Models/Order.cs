using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models;

public class Order : BaseEntity
{
    public double TotalPrice { get; set; }

    public int UserId { get; set; }

    [ForeignKey(nameof(UserId))]
    public virtual User? user { get; set; }

    public virtual IEnumerable<OrderItem>? OrderItems { get; set; }
}
