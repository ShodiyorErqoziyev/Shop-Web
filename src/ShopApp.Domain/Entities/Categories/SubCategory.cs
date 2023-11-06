namespace ShopApp.Domain.Entities;

public class SubCategory : Auditable
{
    public long CategoryId { get; set; }
    public string Name { get; set; } = String.Empty;
    public string Description { get; set; } = String.Empty;
    public string ImagePath { get; set; } = String.Empty;
}
