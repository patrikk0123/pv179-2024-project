using BusinessLayer.DTOs.Order;

namespace BusinessLayer.Services.Order.Interfaces;

public interface IOrderService
{
    public Task<List<OrderDto>> GetAllOrdersAsync();

    public Task<List<OrderDto>> GetAllOrdersAsync(int userId);

    public Task<OrderDetailDto?> GetSingleOrderAsync(int orderId);

    public Task<OrderDto?> CreateOrderAsync(OrderCreateDto orderCreateDto, int userId);
}
