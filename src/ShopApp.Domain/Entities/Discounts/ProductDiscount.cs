namespace ShopApp.Domain.Entities;

public class ProductDiscount : Auditable
{
    public long ProductId { get; set; }
    public long DiscountId { get; set; }
    public DateTime StartAt { get; set; }
    public DateTime EndAt { get; set; }
    public string ProductDescription { get; set; } = String.Empty;
}
