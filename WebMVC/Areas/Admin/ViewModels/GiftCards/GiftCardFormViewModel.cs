namespace WebMVC.Areas.Admin.ViewModels.GiftCards;

public class GiftCardFormViewModel
{
    public string PriceReduction { get; set; }

    public int AmountOfCoupons { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime ExpiryDate { get; set; }
}
