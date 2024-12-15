using BusinessLayer.DTOs.Coupon;
using BusinessLayer.DTOs.GiftCard;
using BusinessLayer.Mappers.Interfaces;
using BusinessLayer.Services.GiftCard.Interfaces;
using DAL.Data;
using Microsoft.EntityFrameworkCore;

namespace BusinessLayer.Services.GiftCard;

public class GiftCardService(BookHubDBContext dBContext, IGiftCardMapper giftCardMapper)
    : BaseService(dBContext),
        IGiftCardService
{
    public async Task<List<GiftCardDto>> GetAllGiftCardsAsync()
    {
        var giftCards = await dBContext
            .GiftCards.Select(giftCard => giftCardMapper.ToDto(giftCard))
            .ToListAsync();
        return giftCards;
    }

    public async Task<GiftCardDetailDto?> GetSingleGiftCardAsync(int giftCardId)
    {
        var giftCard = await dBContext
            .GiftCards.Include(x => x.Coupons)
            .FirstOrDefaultAsync(x => x.Id == giftCardId);

        if (giftCard == null)
        {
            return null;
        }

        return giftCardMapper.ToDetailDto(giftCard);
    }

    public async Task<GiftCardDto?> CreateSingleGiftCardAsync(GiftCardCreateDto giftCardCreateDto)
    {
        var giftCard = giftCardMapper.ToModel(giftCardCreateDto);
        await dBContext.GiftCards.AddAsync(giftCard);
        await SaveAsync(true);

        var resGiftCard = await dBContext.GiftCards.FirstOrDefaultAsync(x => x.Id == giftCard.Id);

        if (resGiftCard == null)
        {
            return null;
        }

        return giftCardMapper.ToDto(resGiftCard);
    }

    public async Task<GiftCardDto?> UpdateSingleGiftCardAsync(
        int giftCardId,
        GiftCardUpdateDto giftCardUpdateDto
    )
    {
        var giftCard = await dBContext.GiftCards.FirstOrDefaultAsync(x => x.Id == giftCardId);

        if (giftCard == null)
        {
            return null;
        }

        giftCardMapper.UpdateModel(giftCard, giftCardUpdateDto);
        await SaveAsync(true);

        var resGiftCard = await dBContext.GiftCards.FirstOrDefaultAsync(x => x.Id == giftCard.Id);

        if (resGiftCard == null)
        {
            return null;
        }

        return giftCardMapper.ToDto(resGiftCard);
    }

    public async Task<GiftCardDto?> DeleteSingleGiftCardAsync(int giftCardId)
    {
        var giftCard = dBContext
            .GiftCards.Include(x => x.Coupons)
            .FirstOrDefault(x => x.Id == giftCardId);

        if (giftCard == null)
        {
            return null;
        }

        await using var transaction = await dBContext.Database.BeginTransactionAsync();
        try
        {
            var freeCoupons = giftCard.Coupons!.Where(coupon => coupon.OrderId == null);

            if (giftCard.Coupons!.Count() == freeCoupons.Count())
            {
                giftCard.DeletedAt = DateTime.Now;
                dBContext.GiftCards.Update(giftCard);
            }

            dBContext.Coupons.RemoveRange(freeCoupons);

            await SaveAsync(true);

            await transaction.CommitAsync();
        }
        catch (Exception)
        {
            await transaction.RollbackAsync();
            throw;
        }

        return giftCardMapper.ToDto(giftCard);
    }

    public async Task<bool> CheckCouponIsValidAsync(string couponCode)
    {
        var coupon = await dBContext
            .Coupons.Include(coupon => coupon.GiftCard)
            .FirstOrDefaultAsync(coupon => coupon.Code == couponCode);

        return coupon != null
            && coupon.OrderId == null
            && coupon.GiftCard != null
            && coupon.GiftCard.StartDate <= DateTime.UtcNow
            && DateTime.UtcNow <= coupon.GiftCard.ExpiryDate;
    }

    public async Task<CouponDetailDto?> GetCouponAsync(string couponCode)
    {
        var coupon = await dBContext
            .Coupons.Include(coupon => coupon.GiftCard)
            .FirstOrDefaultAsync(coupon => coupon.Code == couponCode);

        if (coupon == null || coupon.GiftCard == null)
        {
            return null;
        }

        return new CouponDetailDto
        {
            Id = coupon.Id,
            Code = coupon.Code,
            GiftCard = giftCardMapper.ToDto(coupon.GiftCard),
            IsUsed = coupon.OrderId != null,
        };
    }
}
