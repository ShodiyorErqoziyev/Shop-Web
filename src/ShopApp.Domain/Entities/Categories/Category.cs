using System.ComponentModel.DataAnnotations;

namespace ShopApp.Domain.Entities;

public class Category : Auditable
{
    [MaxLength(20)]
    public string Name { get; set; } = String.Empty;
    public string ImagePath { get; set; } = String.Empty;
    public string Description { get; set; } = String.Empty;
}
