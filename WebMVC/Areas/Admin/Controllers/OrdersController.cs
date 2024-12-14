using BusinessLayer.DTOs.Order;
using BusinessLayer.Services.Order.Interfaces;
using Mapster;
using Microsoft.AspNetCore.Mvc;
using WebMVC.Areas.Admin.ViewModels.Orders;
using WebMVC.ViewModels.Order;

namespace WebMVC.Areas.Admin.Controllers;

public class OrdersController(IOrderService orderService) : AdminController
{
    public async Task<IActionResult> Index()
    {
        var orders = await orderService.GetAllOrdersAsync();

        var model = orders.Adapt<OrderListViewModel>();

        return View(model);
    }

    [HttpGet("admin/orders/{orderId}")]
    public async Task<IActionResult> Detail(int orderId)
    {
        var order = await orderService.GetSingleOrderAsync(orderId);
        if (order == null)
        {
            return NotFound();
        }

        var model = order.Adapt<OrderDetailViewModel>();

        return View(model);
    }

    [HttpGet("admin/orders/update/{orderId}")]
    public async Task<IActionResult> Update(int orderId)
    {
        var order = await orderService.GetSingleOrderAsync(orderId);
        if (order == null)
        {
            return NotFound();
        }

        var model = order.Adapt<OrderUpdateViewModel>();

        return View(model);
    }

    [HttpPost("admin/orders/update/{orderId}")]
    public async Task<IActionResult> Update(int orderId, OrderUpdateViewModel model)
    {
        if (ModelState.IsValid)
        {
            var orderUpdateDto = model.Adapt<OrderUpdateDto>();
            await orderService.UpdateSingleOrderAsync(orderId, orderUpdateDto);

            return RedirectToAction("Index");
        }

        return View(model);
    }
}
