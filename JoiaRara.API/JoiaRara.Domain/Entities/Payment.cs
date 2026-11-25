namespace JoiaRara.Domain.Entities;

public class Payment : Entity
{
    protected Payment()
    {
        
    }
    
    public Payment(Guid id, DateTime creatOn, DateTime modifyOn, PaymentMethod paymentMethod, 
        DateTime? paymentDate, DateTime scheduledPaymentDate, Guid saleId)
        : base(id, creatOn, modifyOn)
    {
        PaymentMethod = paymentMethod;
        PaymentDate = paymentDate;
        ScheduledPaymentDate = scheduledPaymentDate;
        SaleId = saleId;
    }
    
    
    public PaymentMethod PaymentMethod { get; private set; }
    public DateTime? PaymentDate { get; private set; }
    public DateTime ScheduledPaymentDate { get; private set; }

    public Guid SaleId { get; set; }
    public Sale Sale { get; set; }
    
}