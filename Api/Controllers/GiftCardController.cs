using BusinessLayer.DTOs.GiftCard;
using BusinessLayer.Services.GiftCard.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("/giftcards")]
public class GiftCardController(IGiftCardService giftCardService) : Controller
{
    [HttpGet]
    public async Task<IActionResult> GetAllGiftCards()
    {
        return Ok(await giftCardService.GetAllGiftCardsAsync());
    }

    [HttpGet]
    [Route("{giftCardId}")]
    public async Task<IActionResult> GetGiftCardDetail(int giftCardId)
    {
        var giftCard = await giftCardService.GetSingleGiftCardAsync(giftCardId);
        if (giftCard == null)
        {
            return NotFound();
        }

        return Ok(giftCard);
    }

    [HttpPost]
    public async Task<IActionResult> CreateGiftCard([FromBody] GiftCardCreateDto giftCardCreateDto)
    {
        var createdGiftCard = await giftCardService.CreateSingleGiftCardAsync(giftCardCreateDto);

        if (createdGiftCard == null)
        {
            return BadRequest();
        }

        return CreatedAtAction(
            nameof(GetGiftCardDetail),
            new { giftCardId = createdGiftCard.Id },
            createdGiftCard
        );
    }

    [HttpPut]
    [Route("{giftCardId}")]
    public async Task<IActionResult> UpdateGiftCard(
        int giftCardId,
        [FromBody] GiftCardUpdateDto giftCardUpdateDto
    )
    {
        var updatedGiftCard = await giftCardService.UpdateSingleGiftCardAsync(
            giftCardId,
            giftCardUpdateDto
        );

        if (updatedGiftCard == null)
        {
            return NotFound();
        }

        return Ok(updatedGiftCard);
    }

    [HttpDelete]
    [Route("{giftCardId}")]
    public async Task<IActionResult> DeleteGiftCard(int giftCardId)
    {
        var deletedGiftCard = await giftCardService.DeleteSingleGiftCardAsync(giftCardId);
        if (deletedGiftCard == null)
        {
            return NotFound();
        }

        return Ok(deletedGiftCard);
    }

    [HttpGet]
    [Route("coupon/{couponCode}/is-valid")]
    public async Task<IActionResult> CheckCouponIsValid(string couponCode)
    {
        var isValid = await giftCardService.CheckCouponIsValidAsync(couponCode);
        return Ok(isValid);
    }

    [HttpGet]
    [Route("coupon/{couponCode}")]
    public async Task<IActionResult> GetCoupon(string couponCode)
    {
        var coupon = await giftCardService.GetCouponAsync(couponCode);
        if (coupon == null)
        {
            return NotFound();
        }

        return Ok(coupon);
    }
}
