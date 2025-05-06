
namespace DalApi;

public interface IDal
{
    ICustomer Customer { get; }
    ISale Sale { get; }
    IProduct Product { get; }
}
