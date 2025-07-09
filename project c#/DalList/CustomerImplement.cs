using DO;
using DalApi;
using Tools;
using System.Reflection;

namespace Dal;

internal class CustomerImplement : ICustomer
{
    public int Create(Customer item)
    {
        LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "create customer");
        if (DataSource.CustomersList.Any(c => c.customerId == item.customerId))
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "there is such item already");
            throw new DalExistsAlreadyException("there is such item already ,customer");
        }
        DataSource.CustomersList.Add(item);
        LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "create customer");
        return item.customerId;
    }
    public Customer? Read(int id)
    {
        LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read customer");
        if (!DataSource.CustomersList.Any(c => c.customerId == id))
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "id not found");
            throw new DalDoesNotExistException("id not found ,customer");
        }
        Customer c = DataSource.CustomersList.Single(c => c.customerId == id);
        LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read customer");
        return c;
    }
    public Customer? Read(Func<Customer, bool> func)
    {
        LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read customer");
        if (func == null)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "func is null");
            throw new DalFuncIsNullException("func is null, Customer");
        }
        Customer c = DataSource.CustomersList.First(func);
        if (c == null)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "id not found");
            throw new DalDoesNotExistException("id not found ,customer");
        }
        LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read customer");
        return c;
    }
    public List<Customer> ReadAll(Func<Customer, bool> func)
    {
        LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read all customer");
        LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read all customer ");
        if (func != null)
        {
            IEnumerable<Customer> l = DataSource.CustomersList.Where(func).Select(c => c);
            return (List<Customer>)l;
        }
        return new List<Customer>(DataSource.CustomersList);
    }
    public void Update(Customer item)
    {
        LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "update customer");

        var CustomerCopy = new List<Customer>(DataSource.CustomersList);
        foreach (var item2 in CustomerCopy)
        {
            if (item.customerId == item2.customerId)
            {
                Delete(item.customerId);
                DataSource.CustomersList.Add(item);
                LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "update customer");
                return;
            }
        }
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "id not found");
        throw new DalDoesNotExistException("id not found ,customer");

    }
    public void Delete(int id)
    {
        LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Delete customer");
        DataSource.CustomersList.Remove(Read(id));
        LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Delete customer");
    }
}
