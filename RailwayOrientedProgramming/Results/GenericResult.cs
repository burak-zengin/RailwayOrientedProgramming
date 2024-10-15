namespace RailwayOrientedProgramming.Results;

internal class Result<T> : Result
{
    public T Data { get; set; }

    public static Result<T> Failure(Error error)
    {
        return new Result<T> { Failed = true, Error = error };
    }
}
