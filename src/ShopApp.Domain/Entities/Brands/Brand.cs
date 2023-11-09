namespace ShopApp.Domain.Entities;

public class Brand : Auditable
{
    public string Name { get; set; } = String.Empty;
    public string BrandIconPath { get; set; } = String.Empty;
}
