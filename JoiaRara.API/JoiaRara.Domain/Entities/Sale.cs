namespace JoiaRara.Domain.Entities;

public class Sale : Entity
{
    private readonly List<ItemSale> _itemSales = new();
    protected Sale()
    {
        
    }
    
    public Sale(Guid id, DateTime creatOn, DateTime modifyOn,
        string? observations, Guid customerId) : base(id, creatOn, modifyOn)
    {
        Observations = observations;
        CustomerId = customerId;
    }
    
    public string? Observations { get; private set; }

    // Property Navigations
    public Guid CustomerId { get; private set; }
    public User Customer { get; private set; }
    public IReadOnlyCollection<ItemSale> ItemSales => _itemSales.AsReadOnly();
    public decimal TotalValue => _itemSales.Sum(i => i.TotalValue);
    public void AddItem(Guid itemBatchId, decimal unitPrice, int quantity)
    {
        var item = new ItemSale(
            Guid.NewGuid(), DateTime.UtcNow, DateTime.UtcNow,
            unitPrice, quantity, Id, itemBatchId);

        _itemSales.Add(item);
    }
}