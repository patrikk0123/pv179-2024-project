using Api.DTOs.Order;
using DAL.Models;

namespace Api.Mappers.Interfaces;

public interface IOrderMapper
    : IEntityMapper<Order, OrderDto, OrderDetailDto, OrderCreateDto, OrderUpdateDto> { }
