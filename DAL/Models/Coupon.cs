using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models;

public class Coupon : BaseEntity
{
    public required string Code { get; set; }

    public int GiftCardId { get; set; }

    [ForeignKey(nameof(GiftCardId))]
    public virtual GiftCard? GiftCard { get; set; }

    public int? OrderId { get; set; }

    [ForeignKey(nameof(OrderId))]
    public virtual Order? Order { get; set; }
}
