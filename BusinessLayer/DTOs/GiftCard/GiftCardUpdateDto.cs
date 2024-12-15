﻿using System.ComponentModel.DataAnnotations;

namespace BusinessLayer.DTOs.GiftCard;

public class GiftCardUpdateDto
{
    [Required]
    public required double PriceReduction { get; init; }

    [Required]
    public required DateTime StartDate { get; set; }

    [Required]
    public required DateTime ExpiryDate { get; set; }
}
