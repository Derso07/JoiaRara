namespace JoiaRara.Domain.Entities;

public class ItemSale : Entity
{
    protected ItemSale()
    {
        
    }
    
    public ItemSale(Guid id, DateTime creatOn, DateTime modifyOn, decimal unitPrice, decimal totalValue,
        int quantity, Guid saleId, Guid itemBatchId) : base(id, creatOn, modifyOn)
    {
        UnitPrice = unitPrice;
        TotalValue = totalValue;
        Quantity = quantity > 0? quantity : 0;
        SaleId = saleId;
        ItemBatchId = itemBatchId;
    }

    public decimal UnitPrice { get; private set; }
    public decimal TotalValue { get; private set; }
    public int Quantity { get; private set; }

    //Property Navigation
    public Guid SaleId { get; private set; }
    public Sale Sale { get; private set; }

    public Guid ItemBatchId { get; private set; }
    public ItemBatch ItemBatch { get; private set; }
}