using JoiaRara.Domain.Enum;

namespace JoiaRara.Domain.Entities;

public class Jewel(
    Guid id,
    string description,
    string name,
    int code,
    JewelStatus jewelStatus,
    decimal price,
    string photoUrl,
    string photoId,
    Guid batchId) : Entity(id, DateTime.UtcNow,DateTime.UtcNow)
{
    public int Code { get; private set; } = code;
    public string Name { get; private set; } = name;
    public string Description { get; private set; } = description;
    public JewelStatus JewelStatus { get; private set; } = jewelStatus;
    public decimal Price { get; private set; } = price;
    public string PhotoURL { get; private set; } = photoUrl;
    public string PhotoId { get; private set; } = photoId;
    
    //Property Navigation
    public Guid BatchId { get; set; } = batchId;
    public Batch Batch { get; set; }

    public void MarkAsActive(JewelStatus jewelActive)
    {
        JewelStatus = jewelActive;  
    }

    public void MarkAsInactive(JewelStatus jewelInactive,StatusBatch batchCancelOrReturned)
    {
        if (batchCancelOrReturned is StatusBatch.Returned or StatusBatch.Expired)
        {
            JewelStatus = jewelInactive;
        }
    }
}