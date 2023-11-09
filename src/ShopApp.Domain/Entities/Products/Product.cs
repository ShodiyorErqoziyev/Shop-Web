using System.ComponentModel.DataAnnotations;

namespace ShopApp.Domain.Entities;

public class Product : Auditable
{
    [MaxLength(30)]
    public string Name { get; set; } = String.Empty;
    public long BrandId { get; set; }
    public long SubCategoryId { get; set; }
    public double Price { get; set; }
    public string Description { get; set; } = String.Empty;
    public string ImagePath { get; set; } = String.Empty;
}