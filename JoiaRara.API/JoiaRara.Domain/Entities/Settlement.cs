namespace JoiaRara.Domain.Entities;

public class Settlement
{
    protected Settlement()
    {
        
    }
    public Settlement(DateTime closingDate, decimal transferAmount)
    {
        ClosingDate = closingDate;
        TransferAmount = transferAmount;
    }

    public DateTime ClosingDate { get; private set; }
    public decimal TransferAmount { get; private set; }
}