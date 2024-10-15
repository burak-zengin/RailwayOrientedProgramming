namespace RailwayOrientedProgramming.Results;

internal class Error(string message)
{
    public string Message { get; init; } = message;
}
