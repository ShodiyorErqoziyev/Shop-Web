namespace ShopApp.Domain.Entities;

public class Auditable : BaseEntitty
{
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
