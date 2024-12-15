using BusinessLayer.DTOs.Coupon;
using BusinessLayer.DTOs.GiftCard;
using BusinessLayer.Mappers.Interfaces;
using DAL.Models;

namespace BusinessLayer.Mappers;

public class GiftCardMapper : IGiftCardMapper
{
    private const int CouponCodeLength = 10;

    public GiftCardDto ToDto(GiftCard entity)
    {
        return new GiftCardDto
        {
            Id = entity.Id,
            PriceReduction = entity.PriceReduction,
            StartDate = entity.StartDate,
            ExpiryDate = entity.ExpiryDate,
            AmountOfCoupons = entity.Coupons?.Count() ?? 0,
        };
    }

    public GiftCardDetailDto ToDetailDto(GiftCard entity)
    {
        return new GiftCardDetailDto
        {
            Id = entity.Id,
            PriceReduction = entity.PriceReduction,
            StartDate = entity.StartDate,
            ExpiryDate = entity.ExpiryDate,
            AmountOfCoupons = entity.Coupons?.Count() ?? 0,
            Coupons =
                entity
                    .Coupons?.Select(c => new CouponDto
                    {
                        Id = c.Id,
                        Code = c.Code,
                        IsUsed = c.OrderId != null,
                    })
                    .ToList() ?? [],
        };
    }

    public GiftCard ToModel(GiftCardCreateDto dto)
    {
        var coupons = new List<Coupon>();
        for (int i = 0; i < dto.AmountOfCoupons; i++)
        {
            coupons.Add(new Coupon { Code = Guid.NewGuid().ToString("N")[..CouponCodeLength] });
        }

        return new GiftCard
        {
            PriceReduction = dto.PriceReduction,
            StartDate = dto.StartDate,
            ExpiryDate = dto.ExpiryDate,
            Coupons = coupons,
        };
    }

    public void UpdateModel(GiftCard giftCard, GiftCardUpdateDto dto)
    {
        giftCard.PriceReduction = dto.PriceReduction;
        giftCard.StartDate = dto.StartDate;
        giftCard.ExpiryDate = dto.ExpiryDate;
    }
}
