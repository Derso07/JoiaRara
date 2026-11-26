namespace JoiaRara.Domain.Exception;

public class DomainException : System.Exception
{
    public DomainException(string message) : base(message)
    {
    }
}