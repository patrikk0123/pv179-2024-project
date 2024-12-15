using System.ComponentModel.DataAnnotations;
using BusinessLayer.DTOs.Common;

namespace BusinessLayer.DTOs.Coupon;

public class CouponDto : BaseDto
{
    [Required]
    public required string Code { get; init; }

    [Required]
    public required bool IsUsed { get; init; }
}
