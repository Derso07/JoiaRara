namespace JoiaRara.Domain.Entities;

public abstract class Entity
{
    protected Entity()
    {
        // Usado pelo Entity Framework Core
    }
    protected Entity(Guid id, DateTime createdOn, DateTime modifiedOn)
    {
        Id = id;
        CreatedOn = createdOn;
        ModifyOn = modifiedOn;
    }
    
    public Guid Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public DateTime ModifyOn { get; set; }

    public void UpdateModificationDate()
    {
        ModifyOn = DateTime.UtcNow;
    }
}