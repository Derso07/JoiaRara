namespace JoiaRara.Application.Result;

public class Result<T>
{
    public bool Success { get; }

    public T? Data { get; }

    public IReadOnlyCollection<string> Errors { get; }

    public bool IsFailure => !Success;

    private Result(
        bool success,
        T? data,
        IEnumerable<string>? errors)
    {
        Success = success;
        Data = data;
        Errors = errors?.ToArray() ?? [];
    }

    public static Result<T> Ok(T data)
    {
        return new Result<T>(
            success: true,
            data: data,
            errors: null);
    }

    public static Result<T> Fail(params string[] errors)
    {
        return new Result<T>(
            success: false,
            data: default,
            errors: errors);
    }

    public static Result<T> Fail(IEnumerable<string> errors)
    {
        return new Result<T>(
            success: false,
            data: default,
            errors: errors);
    }
}