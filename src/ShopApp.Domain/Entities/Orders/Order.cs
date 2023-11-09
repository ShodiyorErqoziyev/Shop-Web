namespace ShopApp.Domain.Entities;

public class Order : Auditable
{
    public long UserId { get; set; }
    public decimal ProductsPrice { get; set; }
    public bool IsContracted { get; set; }
    public bool IsPaid { get; set; }
    public string Status { get; set; } = String.Empty;
    public string Description { get; set; } = String.Empty;
    public string PaymentType { get; set; } = String.Empty;
}
