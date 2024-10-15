using RailwayOrientedProgramming.Results;

namespace RailwayOrientedProgramming.Extensions;

internal static class ResultExtensions
{
    internal static Result<string> Ensure(this string value, Func<string, bool> predicate, Error error)
    {
        if (predicate(value))
        {
            return new Result<string>();
        }

        return Result<string>.Failure(error);
    }

    internal static Result<T> Ensure<T>(this Result<T> result, Func<T, bool> predicate, Error error)
    {
        if (result.Failed)
        {
            return result;
        }

        if (predicate(result.Data))
        {
            return result;
        }

        return Result<T>.Failure(error);
    }

    internal static Result<TOut> Map<TIn, TOut>(this Result<TIn> result, Func<TIn, TOut> func)
    {
        return result.Failed ? 
            Result<TOut>.Failure(result.Error) : 
            new Result<TOut> {
                Data = func(result.Data),
                Failed = false
            };
    }
}
