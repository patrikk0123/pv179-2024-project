using BusinessLayer.DTOs.Order;
using DAL.Models;

namespace BusinessLayer.Mappers.Interfaces;

public interface IOrderMapper
    : IEntityMapper<Order, OrderDto, OrderDetailDto, OrderCreateDto, OrderUpdateDto>;
