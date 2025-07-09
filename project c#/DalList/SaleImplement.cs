using DO;
using DalApi;
using System.Linq;
using System.Reflection;
using Tools;
using System.Reflection.Metadata;


namespace Dal;

internal class SaleImplement:ISale
{
    public int Create(Sale item)
    {
        LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "create sale");
        if (DataSource.SalesList.Any(c => c.saleId == item.saleId))
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "there is such item already");
            throw new DalExistsAlreadyException("there is such item already ,sale");
        }
        DataSource.SalesList.Add(item);
        LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "create sale");
        return item.saleId;
    }
    public Sale? Read(int id)
    {
        LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read Sale");
        if (!DataSource.SalesList.Any(c => c.saleId == id))
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "id not found");
            throw new DalDoesNotExistException("id not found ,Sale");
        }
        Sale c = DataSource.SalesList.Single(c => c.saleId == id);
        LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read Sale");
        return c;
    }
    public Sale? Read(Func<Sale, bool> func)
    {
        LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read Sale");
        if (func == null)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "func is null");
            throw new DalFuncIsNullException("func is null, Sale");
        }
        Sale c = DataSource.SalesList.First(func);
        if (c == null)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "id not found");
            throw new DalDoesNotExistException("id not found ,Sale");
        }
        LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read Sale");
        return c;
    }
    public List<Sale> ReadAll(Func<Sale, bool> func)
    {
        LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read all sale");
        LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read all sale");
        if (func != null)
        {
            IEnumerable<Sale> l = DataSource.SalesList.Where(func).Select(c => c);
            return (List<Sale>)l;
        }
        return new List<Sale>(DataSource.SalesList);
    }
    public void Update(Sale item)
    {
        LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "update sale");
        var salesCopy = new List<Sale>(DataSource.SalesList);
        foreach (var item2 in salesCopy)
        {
            if (item.saleId == item2.saleId)
            {
                Delete(item.saleId);
                DataSource.SalesList.Add(item);
                LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "update sale");
                return;
            }

        }
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "id not found");
        throw new DalDoesNotExistException("there is no such item ,sale");

    }
    public void Delete(int id)
    {
        LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "delete sale");
        LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "delete sale");
        DataSource.SalesList.Remove(Read(id));
    }
}
