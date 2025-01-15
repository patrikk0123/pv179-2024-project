using BusinessLayer.DTOs.GiftCard;
using DAL.Models;

namespace BusinessLayer.Mappers.Interfaces;

public interface IGiftCardMapper
    : IEntityMapper<GiftCard, GiftCardDto, GiftCardDetailDto, GiftCardCreateDto, GiftCardUpdateDto>;
