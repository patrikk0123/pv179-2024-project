using System.ComponentModel.DataAnnotations;
using BusinessLayer.DTOs.GiftCard;

namespace BusinessLayer.DTOs.Coupon;

public class CouponDetailDto : CouponDto
{
    [Required]
    public required GiftCardDto GiftCard { get; init; }
}
