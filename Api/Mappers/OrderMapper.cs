using Api.DTOs.Order;
using Api.DTOs.OrderItem;
using Api.Mappers.Interfaces;
using DAL.Models;

namespace Api.Mappers;

public class OrderMapper(IBookMapper bookMapper) : IOrderMapper
{
    public OrderDto ToDto(Order order)
    {
        return new OrderDto
        {
            Id = order.Id,
            UserId = order.UserId,
            TotalPrice = order.TotalPrice,
        };
    }

    public OrderDetailDto ToDetailDto(Order order)
    {
        return new OrderDetailDto
        {
            Id = order.Id,
            UserId = order.UserId,
            TotalPrice = order.TotalPrice,
            OrderItems = order
                .OrderItems.Select(oi => new OrderItemDto
                {
                    Id = oi.Id,
                    Book = bookMapper.ToDto(oi.Book),
                    Quantity = oi.Quantity,
                    Price = oi.PricePerItem,
                })
                .ToList(),
        };
    }

    public Order ToModel(OrderCreateDto dto)
    {
        return new Order();
    }

    public void UpdateModel(Order model, OrderUpdateDto updateDto) { }
}
