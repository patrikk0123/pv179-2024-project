using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models;

public class OrderItem : BaseEntity
{
    public int OrderId { get; set; }

    [ForeignKey(nameof(OrderId)), Required]
    public virtual Order Order { get; set; } = null!;

    public int BookId { get; set; }

    [ForeignKey(nameof(BookId)), Required]
    public virtual Book Book { get; set; } = null!;

    public int Quantity { get; set; }

    public double PricePerItem { get; set; }
}
