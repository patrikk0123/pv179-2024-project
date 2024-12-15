namespace DAL.Models;

public class GiftCard : BaseEntity
{
    public double PriceReduction { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime ExpiryDate { get; set; }

    public virtual IEnumerable<Coupon>? Coupons { get; set; }
}
