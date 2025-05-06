using DO;
using DalApi;
using System.Reflection;
using Tools;


namespace Dal;

internal class ProductImplement : IProduct
{
    public int Create(Product item)
    {
        LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Create Product");
        if (DataSource.ProductsList.Any(i=>i.productId==item.productId))
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "there is such item already");
            throw new DalExistsAlreadyException("there is such item already ,product");
        }
        DataSource.ProductsList.Add(item);
        LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Create Product");
        return item.productId;
    }
    public Product? Read(int id)
    {
        LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read Product");
        if (!DataSource.ProductsList.Any(c => c.productId == id))
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "id not found");
            throw new DalDoesNotExistException("id not found ,Product");
        }
        Product c = DataSource.ProductsList.Single(c => c.productId == id);
        LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read Product");
        return c;
    }
    public Product? Read(Func<Product, bool> func)
    {
        LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read Product");
        if (func == null)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "func is null");
            throw new DalFuncIsNullException("func is null, Product");
        }
        Product c = DataSource.ProductsList.First(func);
        if (c == null)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "id not found");
            throw new DalDoesNotExistException("id not found ,Product");
        }
        LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read Product");
        return c;
    }
    public List<Product> ReadAll(Func<Product, bool> func)
    {
        LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read all Product");
        LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read all Product");
        if (func != null)
        {
            IEnumerable<Product> l = DataSource.ProductsList.Where(func).Select(c => c);
            return (List<Product>)l;
        }
        return new List<Product>(DataSource.ProductsList);
    }
    public void Update(Product item)
    {
        LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "update Product");
        var productsCopy = new List<Product>(DataSource.ProductsList);
        foreach (var item2 in productsCopy)
        {
            if (item.productId == item2.productId)
            {
                Delete(item.productId);
                DataSource.ProductsList.Add(item);
                LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "update Product");
                return;
            }

        }
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "id not found");
        throw new DalDoesNotExistException("there is no such item ,product");

    }
    public void Delete(int id)
    {
        LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Delete Product");
        LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Delete Product");
        DataSource.ProductsList.Remove(Read(id));
    }

}
