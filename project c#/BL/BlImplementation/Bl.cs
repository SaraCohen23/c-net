

using BlApi;

namespace BlImplementation;

internal class Bl:IBl
{
    public ICustomer customer=>new CustomerImplementation();
    public IProduct product => new ProductImplementation();
    public IOrder order => new OrderImplementation();
    public ISale sale => new SaleImplementation();
}
