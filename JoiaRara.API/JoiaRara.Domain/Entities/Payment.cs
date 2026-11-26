namespace JoiaRara.Domain.Entities;

public class Payment : Entity
{
    protected Payment()
    {
        
    }
    
    public Payment(Guid id, DateTime creatOn, DateTime modifyOn, PaymentMethod paymentMethod, 
        DateTime paymentDate, Guid saleId, decimal amountPaid)
        : base(id, creatOn, modifyOn)
    {
        PaymentMethod = paymentMethod;
        PaymentDate = paymentDate;
        SaleId = saleId;
        AmountPaid = amountPaid > 0 ? amountPaid : 0;
    }

    public decimal AmountPaid { get; private set; }
    public PaymentMethod PaymentMethod { get; private set; }
    public DateTime PaymentDate { get; private set; }
    public Guid SaleId { get; private set; }
    public Sale Sale { get; private set; }
    
}