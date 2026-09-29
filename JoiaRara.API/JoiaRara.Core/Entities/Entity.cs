namespace JoiaRara.Domain.Entities;

public abstract class Entity(Guid id, DateTime creatOn, DateTime modifyOn)
{
    public Guid Id { get; set; } = id;
    public DateTime CreatedOn { get; set; } = creatOn;
    public DateTime ModifyOn { get; set; } = modifyOn;

    public void UpdateModificationDate()
    {
        ModifyOn = DateTime.UtcNow;
    }
}