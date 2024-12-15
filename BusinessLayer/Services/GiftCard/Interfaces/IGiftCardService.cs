using BusinessLayer.DTOs.Coupon;
using BusinessLayer.DTOs.GiftCard;

namespace BusinessLayer.Services.GiftCard.Interfaces;

public interface IGiftCardService
{
    public Task<List<GiftCardDto>> GetAllGiftCardsAsync();

    public Task<GiftCardDetailDto?> GetSingleGiftCardAsync(int giftCardId);

    public Task<GiftCardDto?> CreateSingleGiftCardAsync(GiftCardCreateDto giftCardCreateDto);

    public Task<GiftCardDto?> UpdateSingleGiftCardAsync(
        int giftCardId,
        GiftCardUpdateDto giftCardUpdateDto
    );

    public Task<GiftCardDto?> DeleteSingleGiftCardAsync(int giftCardId);

    public Task<bool> CheckCouponIsValidAsync(string couponCode);

    public Task<CouponDetailDto?> GetCouponAsync(string couponCode);
}
