namespace DAL.Models;

public enum OrderStatus
{
    AwaitingPayment = 0,
    PaymentReceived = 1,
    Shipped = 2,
    Delivered = 3,
}
