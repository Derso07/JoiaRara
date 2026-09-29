namespace JoiaRara.Domain.Entities;

public class ItemBatch : Entity
{
    public ItemBatch(Guid id, DateTime creatOn, DateTime modifyOn, int quantity, int quantitySold, int quantityReturned,
        StatusItemJewel statusItemJewel, Batch batch, ICollection<Jewel> jewels) : base(id, creatOn, modifyOn)
    {
        Quantity = quantity;
        QuantitySold = quantitySold;
        QuantityReturned = quantityReturned;
        StatusItemJewel = statusItemJewel;
        Batch = batch;
        Jewels = jewels;
    }

    public int Quantity { get; private set; }
    public int QuantitySold { get; private set; }
    public int QuantityReturned { get; private set; }
    public StatusItemJewel StatusItemJewel { get; private set; }

    //Property Navigation
    public Guid BatchId { get; set; }
    public Batch Batch { get; set; }

    public ICollection<Jewel> Jewels { get; set; }
    
    
}