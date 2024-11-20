using BusinessLayer.DTOs.Order;
using BusinessLayer.Mappers.Interfaces;
using BusinessLayer.Services.Book.Interfaces;
using BusinessLayer.Services.User.Interfaces;
using DAL.Data;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers;

[ApiController]
[Route("/orders")]
public class OrderController(
    IUserService userService,
    BookHubDBContext dBContext,
    IBookService bookService,
    IOrderMapper orderMapper
) : Controller
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

            var anyMissing = await bookService.DoBooksExistAsync(bookIds);

            if (anyMissing)
            {
                return BadRequest("One or more books do not exist.");
            }

            double totalPrice = 0;
            foreach (var oi in orderDto.OrderItems)
            {
                var book = await bookService.GetSingleBookAsync(oi.BookId);
                totalPrice += book.Price * oi.Quantity;
            }

            const int userId = 1; // TODO: Get the user ID from the JWT token
            if (!await userService.DoesUserExistAsync(userId))
            {
                return NotFound("User not found");
            }

            var order = new Order { UserId = userId, TotalPrice = totalPrice };

            await dBContext.Orders.AddAsync(order);

            await dBContext.SaveChangesAsync();

            var orderItems = new List<OrderItem>();
            foreach (var oi in orderDto.OrderItems)
            {
                var book = await bookService.GetSingleBookAsync(oi.BookId);
                orderItems.Add(
                    new OrderItem
                    {
                        OrderId = order.Id,
                        BookId = oi.BookId,
                        Quantity = oi.Quantity,
                        PricePerItem = book.Price,
                    }
                );
            }
            order.OrderItems = orderItems;

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
