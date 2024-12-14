using BusinessLayer.DTOs.Order;
using BusinessLayer.Services.Book.Interfaces;
using BusinessLayer.Services.Order.Interfaces;
using BusinessLayer.Services.User.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("/orders")]
public class OrderController(
    IUserService userService,
    IBookService bookService,
    IOrderService orderService
) : Controller
{
    [HttpGet]
    public async Task<IActionResult> GetAllOrders()
    {
        return Ok(await orderService.GetAllOrdersAsync());
    }

    [HttpGet]
    [Route("{orderId}")]
    public async Task<IActionResult> GetSingleOrder(int orderId)
    {
        var order = await orderService.GetSingleOrderAsync(orderId);

        if (order == null)
        {
            return NotFound();
        }

        return Ok(order);
    }

    [HttpPost]
    public async Task<IActionResult> CreateOrder([FromBody] OrderCreateDto orderDto)
    {
        const int userId = 1; // TODO: Get the user ID from the JWT token
        if (!await userService.DoesUserExistAsync(userId))
        {
            return NotFound("User not found");
        }

        var bookIds = orderDto.OrderItems.ConvertAll(oi => oi.BookId);

        if (!await bookService.DoBooksExistAsync(bookIds))
        {
            return BadRequest("One or more books do not exist.");
        }

        var order = await orderService.CreateOrderAsync(orderDto, userId);

        return CreatedAtAction(nameof(GetSingleOrder), new { orderId = order.Id }, order);
    }

    [HttpPut]
    [Route("{orderId}")]
    public async Task<IActionResult> UpdateOrder(
        int orderId,
        [FromBody] OrderUpdateDto orderUpdateDto
    )
    {
        var updatedOrder = await orderService.UpdateSingleOrderAsync(orderId, orderUpdateDto);
        if (updatedOrder == null)
        {
            return NotFound();
        }

        return Ok(updatedOrder);
    }
}
