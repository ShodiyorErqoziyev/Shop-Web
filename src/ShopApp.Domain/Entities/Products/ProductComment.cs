namespace ShopApp.Domain.Entities;

public class ProductComment : Auditable
{
    public long ProductId { get; set; }
    public long UserId { get; set; }
    public string Comment { get; set; } = String.Empty;
}
