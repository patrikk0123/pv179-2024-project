using System.ComponentModel.DataAnnotations;
using BusinessLayer.DTOs.Coupon;

namespace BusinessLayer.DTOs.GiftCard;

public class GiftCardDetailDto : GiftCardDto
{
    [Required]
    public required IEnumerable<CouponDto> Coupons { get; init; }
}
