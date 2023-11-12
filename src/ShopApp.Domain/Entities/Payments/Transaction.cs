namespace ShopApp.Domain.Entities;

public class Transaction : Auditable
{
    public long UserId { get; set; }
    public string SenderCardNumber { get; set; } = String.Empty;
    public string ReceiverCardNumber { get; set; } = String.Empty;
    public decimal RequiredAmount { get; set; }
    public bool IsTransfered { get; set; } = false;
    public string Status { get; set; } = String.Empty;
}
