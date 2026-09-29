namespace JoiaRara.Domain.Entities;

public class User(
    Guid id,
    DateTime creatOn,
    DateTime modifyOn,
    StatusUser statusUser,
    string email,
    string cpf,
    string name,
    string passwordHash,
    ICollection<UserRole> roles) : Entity(id, creatOn, modifyOn)
{
    public string PasswordHash { get; private set; } = passwordHash;
    public string Name { get; private set; } = name;
    public string Cpf { get; private set; } = cpf;
    public string Email { get; private set; } = email;
    public StatusUser StatusUser { get; set; } = statusUser; 

    public ICollection<UserRole> Roles { get; set; } = roles;

    public void ModifyStatus(StatusUser  statusUser)
    {
        StatusUser = statusUser;
    }
}