namespace BO;
[Serializable]
public class BlDoesNotExistException : Exception
{
    public BlDoesNotExistException(string? message) : base(message) { }
    public BlDoesNotExistException(string message, Exception innerException)
                : base(message, innerException) { }
}
public class BlExistsAlreadyException : Exception
{
    public BlExistsAlreadyException(string? message) : base(message) { }
    public BlExistsAlreadyException(string message, Exception innerException)
                : base(message, innerException) { }
}

public class BlNotInStockException : Exception
{
    public BlNotInStockException(string? message) : base(message) { }
    public BlNotInStockException(string message, Exception innerException)
                : base(message, innerException) { }
}