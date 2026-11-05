
namespace Store.Domain.Exceptions;

public class InsufficientStockException : ConflictException
{
    public InsufficientStockException(string productName)
        : base($"Not enough stock for '{productName}'.")
    {
    }
}
