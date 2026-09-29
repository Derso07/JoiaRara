namespace JoiaRara.Domain.Entities;

public class Sale : Entity
{
    public Sale(Guid id, DateTime creatOn, DateTime modifyOn, int totalValue, PaymentMethod paymentMethod,
        string? observations, Guid customerId, DateTime? paymentDate, DateTime scheduledPaymentDate) : base(id, creatOn, modifyOn)
    {
        TotalValue = totalValue;
        PaymentMethod = paymentMethod;
        Observations = observations;
        CustomerId = customerId;
        PaymentDate = paymentDate;
        ScheduledPaymentDate = scheduledPaymentDate;
    }

    public int TotalValue { get; set; }
    public PaymentMethod PaymentMethod { get; set; }
    public DateTime? PaymentDate { get; set; }
    public DateTime ScheduledPaymentDate { get; set; }
    public string? Observations { get; set; }

    // Property Navigations
    public Guid CustomerId { get; set; }
    public User Customer { get; set; }
}