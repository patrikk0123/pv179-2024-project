using BusinessLayer.DTOs.Order;
using BusinessLayer.Mappers.Interfaces;
using BusinessLayer.Services.Order.Interfaces;
using DAL.Data;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace BusinessLayer.Services.Order;

public class OrderService(BookHubDBContext dBContext, IOrderMapper orderMapper)
    : BaseService(dBContext),
        IOrderService
{
    public async Task<List<OrderDto>> GetAllOrdersAsync()
    {
        var orders = await dBContext.Orders.ToListAsync();

        return orders.ConvertAll(orderMapper.ToDto);
    }

    public async Task<List<OrderDto>> GetAllOrdersAsync(int userId)
    {
        var orders = await dBContext.Orders.Where(item => item.UserId == userId).ToListAsync();

        return orders.ConvertAll(orderMapper.ToDto);
    }

    public async Task<OrderDetailDto?> GetSingleOrderAsync(int orderId)
    {
        var order = await dBContext.Orders.FindAsync(orderId);
        if (order == null)
        {
            return null;
        }

        return orderMapper.ToDetailDto(order);
    }

    public async Task<OrderDto?> CreateOrderAsync(OrderCreateDto orderCreateDto, int userId)
    {
        await using var transaction = await dBContext.Database.BeginTransactionAsync();
        try
        {
            double totalPrice = 0;
            foreach (var oi in orderCreateDto.OrderItems)
            {
                var bookPrice = await GetBookPrice(oi.BookId);
                totalPrice += bookPrice * oi.Quantity;
            }

            var order = new DAL.Models.Order
            {
                UserId = userId,
                TotalPrice = totalPrice,
                OrderStatus = OrderStatus.AwaitingPayment,
            };

            await dBContext.Orders.AddAsync(order);

            await SaveAsync(true);

            var orderItems = new List<OrderItem>();
            foreach (var oi in orderCreateDto.OrderItems)
            {
                var bookPrice = await GetBookPrice(oi.BookId);
                orderItems.Add(
                    new OrderItem
                    {
                        OrderId = order.Id,
                        BookId = oi.BookId,
                        Quantity = oi.Quantity,
                        PricePerItem = bookPrice,
                    }
                );
            }

            dBContext.OrderItem.AddRange(orderItems);

            await SaveAsync(true);

            await transaction.CommitAsync();

            return orderMapper.ToDto(order);
        }
        catch (Exception)
        {
            await transaction.RollbackAsync();
            throw;
        }
    }

    private async Task<double> GetBookPrice(int bookId)
    {
        var book =
            await dBContext.Books.FindAsync(bookId)
            ?? throw new InvalidOperationException("Book not found");

        return book.Price;
    }
}
