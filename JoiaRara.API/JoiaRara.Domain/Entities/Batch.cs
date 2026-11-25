using JoiaRara.Domain.Enum;

namespace JoiaRara.Domain.Entities;

public class Batch : Entity
{
    protected Batch()
    {
    }
    
    public Batch(Guid id, DateTime creatOn, DateTime modifyOn, Guid supplierId, string batchCode,
        DateTime deliveryDate, DateTime estimatedDeliveryDate, DateTime dueDate, StatusBatch statusBatch) : base(id,
        creatOn, modifyOn)
    {
        SupplierId = supplierId;
        BatchCode = batchCode;
        DeliveryDate = deliveryDate;
        DueDate = dueDate;
        StatusBatch = statusBatch;
    }
    public string BatchCode { get; private set; }
    public DateTime? DeliveryDate { get; private set; }
    public DateTime DueDate { get; private set; }
    public StatusBatch StatusBatch { get; private set; }
    
    // Property Navigation
    public Guid SupplierId { get; private set; }
    public User Supplier { get; private set; }
    
    public Guid SellerId { get; private set; }
    public User Seller { get; private set; }
    
    public ICollection<Jewel> Jewels { get; private set; }
        = new List<Jewel>();
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

        throw new InvalidOperationException("Data de devolução não pode ser maior que a data entrega");
    }
}