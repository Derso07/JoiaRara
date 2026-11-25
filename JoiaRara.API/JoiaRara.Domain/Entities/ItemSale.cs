namespace JoiaRara.Domain.Entities;

public class ItemSale : Entity
{
    protected ItemSale()
    {
        
    }
    
    public ItemSale(Guid id, DateTime creatOn, DateTime modifyOn, decimal unitPrice, decimal totalValue,
        Guid saleId, ICollection<Jewel> jewels, Guid jewelId) : base(id, creatOn, modifyOn)
    {
        UnitPrice = unitPrice;
        TotalValue = totalValue;
        SaleId = saleId;
        JewelId = jewelId;
    }

    public decimal UnitPrice { get; private set; }
    public decimal TotalValue { get; private set; }

    //Property Navigation
    public Guid SaleId { get; private set; }
    public Sale Sale { get; private set; }

    public Guid JewelId { get; private set; }
    public Jewel Jewel { get; private set; }
}