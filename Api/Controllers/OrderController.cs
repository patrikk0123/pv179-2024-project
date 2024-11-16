using BusinessLayer.DTOs.Order;
using BusinessLayer.Mappers.Interfaces;
using DAL.Data;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers;

[ApiController]
[Route("/orders")]
public class OrderController(BookHubDBContext dBContext, IOrderMapper orderMapper) : Controller
{
    [HttpGet]
    public async Task<IActionResult> GetALlOrders()
    {
        var orders = await dBContext.Orders.ToListAsync();

        return Ok(orders.Select(orderMapper.ToDto));
    }

    [HttpGet]
    [Route("{orderId}")]
    public async Task<IActionResult> GetSingleOrder(int orderId)
    {
        var order = await dBContext.Orders.FirstOrDefaultAsync(order => order.Id == orderId);

        if (order == null)
        {
            return NotFound();
        }

        return Ok(orderMapper.ToDetailDto(order));
    }

    [HttpPost]
    public async Task<IActionResult> CreateOrder([FromBody] OrderCreateDto orderDto)
    {
        await using var transaction = await dBContext.Database.BeginTransactionAsync();
        try
        {
            var bookIds = orderDto.OrderItems.ConvertAll(oi => oi.BookId);

            var anyMissing =
                await dBContext.Books.Where(b => bookIds.Contains(b.Id)).CountAsync()
                != bookIds.Count;

            if (anyMissing)
            {
                return BadRequest("One or more books do not exist.");
            }

            var totalPrice = orderDto.OrderItems.Sum(oi =>
                dBContext.Books.First(b => b.Id == oi.BookId).Price * oi.Quantity
            );

            const int userId = 1; // TODO: Get the user ID from the JWT token

            var order = new Order { UserId = userId, TotalPrice = totalPrice };

            await dBContext.Orders.AddAsync(order);

            await dBContext.SaveChangesAsync();

            order.OrderItems = orderDto.OrderItems.ConvertAll(oi => new OrderItem
            {
                OrderId = order.Id,
                BookId = oi.BookId,
                Quantity = oi.Quantity,
                PricePerItem = dBContext.Books.First(b => b.Id == oi.BookId).Price,
            });

            await dBContext.SaveChangesAsync();

            await transaction.CommitAsync();

            return CreatedAtAction(
                nameof(GetSingleOrder),
                new { orderId = order.Id },
                orderMapper.ToDto(order)
            );
        }
        catch (Exception)
        {
            await transaction.RollbackAsync();
            throw;
        }
    }
}
