using JoiaRara.Domain.Enum;

namespace JoiaRara.Domain.Entities;

public class ItemBatch : Entity
{
    // Construtor utilizado pelo Entity Framework Core
    protected ItemBatch()
    {
    }

    // Construtor utilizado pela aplicação
    public ItemBatch(
        Guid id,
        DateTime createdOn,
        DateTime modifiedOn,
        int quantity,
        int quantitySold,
        int quantityReturned,
        StatusItemJewel statusItemJewel,
        Guid batchId,
        Guid jewelId)
        : base(id, createdOn, modifiedOn)
    {
        Quantity = quantity;
        QuantitySold = quantitySold;
        QuantityReturned = quantityReturned;
        StatusItemJewel = statusItemJewel;
        BatchId = batchId;
        JewelId = jewelId;
    }

    public int Quantity { get; private set; }

    public int QuantitySold { get; private set; }

    public int QuantityReturned { get; private set; }

    public StatusItemJewel StatusItemJewel { get; private set; }
    
    // //Property Navigation
    public Guid BatchId { get; private set; }
    
    public Batch Batch { get; private set; } = null!;

    public Guid JewelId { get; private set; }
    
    public Jewel Jewel{ get; private set; }
}