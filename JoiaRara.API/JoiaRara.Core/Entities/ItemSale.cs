namespace JoiaRara.Domain.Entities;

public class ItemSale : Entity
{
    public ItemSale(Guid id, DateTime creatOn, DateTime modifyOn, decimal unitPrice, decimal totalValue,
        Guid saleId, Sale sale, ICollection<Jewel> jewels, Guid jewelId, Jewel jewel) : base(id, creatOn, modifyOn)
    {
        UnitPrice = unitPrice;
        TotalValue = totalValue;
        SaleId = saleId;
        Sale = sale;
        JewelId = jewelId;
        Jewel = jewel;
    }

    private decimal UnitPrice { get; set; }
    public decimal TotalValue { get; set; }

    //Property Navigation
    public Guid SaleId { get; set; }
    public Sale Sale { get; set; }

    public Guid JewelId { get; set; }
    public Jewel Jewel { get; set; }
}