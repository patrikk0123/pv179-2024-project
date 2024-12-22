namespace WebMVC.Areas.Admin.ViewModels.GiftCards;

public class GiftCardViewModel
{
    public int Id { get; set; }

    public string PriceReduction { get; set; }

    public int AmountOfCoupons { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime ExpiryDate { get; set; }
}
