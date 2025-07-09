
using DalApi;
using DalXml;
using DO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Xml.Serialization;
using Tools;

namespace Dal;

internal class CustomerImplementation : ICustomer
{
    XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));
    string xmlFilePath = @"../xml/customers.xml";


    public List<Customer> load()
    {
        using (StreamReader sr = new StreamReader(xmlFilePath))
        {
          return serializer.Deserialize(sr) as List<Customer>;
        }
    }

    public void save(List<Customer> l)
    {
        using (StreamWriter sw = new StreamWriter(xmlFilePath))
        {
            serializer.Serialize(sw, l);
        }
    }
    public int Create(Customer item)
    {
        LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "create Customer");
        List<Customer> list = load();
        list.Add(item);
        save(list);
        LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "create Customer");
        return item.customerId;
     
    }

    public void Delete(int id)
    {
        LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "delete Customer");
        List<Customer> list = load();
        Customer customer = list.FirstOrDefault(item=>item.customerId==id);
        if (customer==null)
            throw new DalDoesNotExistException("id not found,customer");
        list.Remove(customer);
        save(list);
        LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "delete Customer");
    }

    public Customer? Read(int id)
    {
        LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Read Customer");
        List<Customer> list = load();
        LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Read Customer");
        Customer?c= list.FirstOrDefault(item => item.customerId == id);
        if (c == null)
            throw new DalDoesNotExistException("id not found,customer");
        return c;
    }

    public Customer? Read(Func<Customer, bool> filter)
    {
        Customer? c=null;
        LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Read Customer");
        List<Customer> list = load();
        LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Read Customer");
        if (filter != null)
          c= list.FirstOrDefault(filter);
        if (c == null)
            throw new DalDoesNotExistException("id not found,customer");
        return c;
        throw new DalFuncIsNullException("func is null, Customer");
    }

    public List<Customer?> ReadAll(Func<Customer, bool>? filter = null)
    {
        LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "ReadAll Customer");
        List<Customer> list = load();
        if (filter != null)
        {
            List<Customer> l =list.Where(filter).ToList();
            return l;
        }
        LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "ReadAll Customer");
        return list;
    }

    public void Update(Customer item)
    {
        LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "update Customer");
        List<Customer> list = load();
        Customer customer = list.FirstOrDefault(i => i.customerId == item.customerId);
        if (customer == null)
            throw new DalDoesNotExistException("id not found,customer");
        list.Remove(customer);
        list.Add(item);
        save(list);
        LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "update Customer");
    }
}
