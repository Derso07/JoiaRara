using JoiaRara.Domain.Enum;
using JoiaRara.Domain.Exceptions;

namespace JoiaRara.Domain.Entities;

public class Batch : Entity
{
    private readonly List<ItemBatch> _itemBatches = new();
    protected Batch()
    {
    }
    
    public Batch(Guid id, DateTime creatOn, DateTime modifyOn, Guid supplierId,Guid sellerId, string batchCode,
        DateTime deliveryDate, DateTime dueDate, StatusBatch statusBatch) : base(id,
        creatOn, modifyOn)
    {
        SellerId = sellerId;
        SupplierId = supplierId;
        BatchCode = batchCode;
        DeliveryDate = deliveryDate;
        DueDate = dueDate;
        StatusBatch = statusBatch;
    }
    public string BatchCode { get; private set; }
    public DateTime DeliveryDate { get; private set; }
    public DateTime DueDate { get; private set; }
    public StatusBatch StatusBatch { get; private set; }
    
    // Property Navigation
    public Guid SupplierId { get; private set; }
    public User Supplier { get; private set; }
    public Guid SellerId { get; private set; }
    public User Seller { get; private set; }

    public ICollection<ItemBatch> ItemBatches { get; private set; }
    
    public void AddItem(int quantity, int quantitySold, int quantityreturned, StatusItemJewel statusItemJewel, Guid batchId, Guid  jewelId)
    {
        var item = new ItemBatch(
            Guid.NewGuid(), DateTime.UtcNow, DateTime.UtcNow,
            quantity, quantitySold, quantityreturned, statusItemJewel, batchId, jewelId);

        _itemBatches.Add(item);
    }
    
    public void MarkAsReceived(StatusBatch received)
    {
        StatusBatch = received;
    }
    
    public void MarkAsDone(StatusBatch returned, DateTime dateReturned)
    {
        if (dateReturned <= DueDate)
        {
            StatusBatch = returned;
        }
        else
        {
            throw new DomainException("Data de devolução não pode ser maior que o prazo");
        }
    }
}