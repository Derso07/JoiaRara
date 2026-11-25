namespace JoiaRara.Domain.Entities;

public class Sale : Entity
{
    protected Sale()
    {
        
    }
    
    public Sale(Guid id, DateTime creatOn, DateTime modifyOn, decimal totalValue, 
        string? observations, Guid customerId,Guid paymentId) : base(id, creatOn, modifyOn)
    {
        TotalValue = totalValue;
        Observations = observations;
        CustomerId = customerId;
        PaymentId = paymentId;
    }

    public decimal TotalValue { get; private set; }
    public string? Observations { get; private set; }

    // Property Navigations
    public Guid CustomerId { get; private set; }
    public User Customer { get; private set; }

    public Guid PaymentId { get; private set; }
    public Payment Payment { get; private set; }
    
    public ICollection<ItemSale> ItemSales { get; set; }

    private void totalValue()
    {
        TotalValue = ItemSales.Sum(i => i.TotalValue);
    }
}