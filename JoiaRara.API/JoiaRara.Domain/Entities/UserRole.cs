namespace JoiaRara.Domain.Entities;

public class UserRole(Guid id, DateTime creatOn, DateTime modifyOn, Guid userId)
    : Entity(id, creatOn, modifyOn)
{
    public Guid UserId { get; set; } = userId;
    public UserRoleType UserRoleType { get; set; }
    
}