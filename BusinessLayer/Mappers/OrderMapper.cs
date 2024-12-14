using BusinessLayer.DTOs.Order;
using BusinessLayer.DTOs.OrderItem;
using BusinessLayer.Mappers.Interfaces;
using DAL.Models;

namespace BusinessLayer.Mappers;

public class OrderMapper(IBookMapper bookMapper) : IOrderMapper
{
    public OrderDto ToDto(Order order)
    {
        return new OrderDto
        {
            Id = order.Id,
            UserId = order.UserId,
            Username = order.User?.Username ?? "",
            OrderStatus = order.OrderStatus,
            TotalPrice = order.TotalPrice,
        };
    }

    public OrderDetailDto ToDetailDto(Order order)
    {
        return new OrderDetailDto
        {
            Id = order.Id,
            UserId = order.UserId,
            Username = order.User?.Username ?? "",
            OrderStatus = order.OrderStatus,
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
        return new Order { OrderStatus = OrderStatus.AwaitingPayment };
    }

    public void UpdateModel(Order model, OrderUpdateDto updateDto)
    {
        model.OrderStatus = updateDto.OrderStatus;
    }
}
