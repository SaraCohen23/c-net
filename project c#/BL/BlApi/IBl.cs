

namespace BlApi;

public interface IBl
{
    IOrder order { get; }
    ICustomer customer { get; }
    IProduct product { get; }
    ISale sale { get; }

}
