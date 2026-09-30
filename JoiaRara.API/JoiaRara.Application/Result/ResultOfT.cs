namespace JoiaRara.Application.Result;

public class ResultOfT
{
    public bool Success { get; }

    public IReadOnlyCollection<string> Errors { get; }

    public bool IsFailure => !Success;

    private ResultOfT(
        bool success,
        IEnumerable<string>? errors)
    {
        Success = success;
        Errors = errors?.ToArray() ?? [];
    }

    public static ResultOfT Ok()
    {
        return new ResultOfT(
            success: true,
            errors: null);
    }

    public static ResultOfT Fail(params string[] errors)
    {
        return new ResultOfT(
            success: false,
            errors: errors);
    }
}