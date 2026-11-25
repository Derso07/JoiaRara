using JoiaRara.Domain.Entities;
using JoiaRara.Domain.Enum;

public class Jewel : Entity
{
    protected Jewel()
    {
    }

    public Jewel(
        Guid id,
        string description,
        string name,
        int code,
        decimal price,
        string photoUrl,
        string photoId,
        Guid batchId)
        : base(id, DateTime.UtcNow, DateTime.UtcNow)
    {
        Code = code;
        Name = name;
        Description = description;
        Price = price;
        PhotoURL = photoUrl;
        PhotoId = photoId;

    }

    public int Code { get; private set; }

    public string Name { get; private set; } = string.Empty;

    public string Description { get; private set; } = string.Empty;

    public decimal Price { get; private set; }

    public string PhotoURL { get; private set; } = string.Empty;

    public string PhotoId { get; private set; } = string.Empty;


}