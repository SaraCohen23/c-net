using DO;
using DalApi;

namespace DalTest;

public static class Initalization
{
    private static IDal? s_dal;
  

    private static void createProduct()
    {
     s_dal.Product.Create(new Product());
      
    }
    private static void createCustomer()
    {
        s_dal.Customer.Create(new Customer());
    }
    private static void createSale()
    {
        s_dal.Sale.Create(new Sale());
    }
    public static void Initialize()
    {
        s_dal = DalApi.Factory.Get;
        createCustomer();
        createProduct();
        createSale();
    }


}
