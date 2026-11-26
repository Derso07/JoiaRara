namespace JoiaRara.Domain.Entities;

public class Settlement : Entity
{
    protected Settlement()
    {
        
    }
    public Settlement(Guid id, DateTime creatOn, DateTime modifyOn,
        DateTime closingDate, decimal transferAmount) : base(id, creatOn, modifyOn)
    {
        ClosingDate = closingDate;
        TransferAmount = transferAmount;
    }

    public DateTime ClosingDate { get; private set; }
    public decimal TransferAmount { get; private set; }
}