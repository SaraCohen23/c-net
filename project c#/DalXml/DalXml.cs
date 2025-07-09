

using DalApi;
using System.Diagnostics;

namespace Dal;

internal sealed class DalXml:IDal
{
    private static readonly DalXml instance=new DalXml();

    public static DalXml Instance
    {
        get { return instance; }
       
    }

    public ICustomer Customer => new CustomerImplementation();

    public IProduct Product => new ProductImplementation();

    public ISale Sale => new SaleImplementation();

    private  DalXml()
    {
       
    }
}
