

using BlApi;
using BO;

namespace BlImplementation;

internal class CustomerImplementation : ICustomer
{
    private DalApi.IDal _dal = DalApi.Factory.Get;

    public int Create(BO.Customer item)
    {
        try
        {
            return _dal.Customer.Create(item.Convert());
        }
        catch (BlExistsAlreadyException ex)
        {
            throw new BlExistsAlreadyException("customer for creation exists already");
        }
    }
    public  BO.Customer? Read(int id)
    {

        try
        {
            return _dal.Customer.Read(id).Convert();
        }
        catch (BlDoesNotExistException ex)
        {
            throw new BlDoesNotExistException("customer for Read doesnt found");
        }
    }
    public BO.Customer? Read(Func<BO.Customer, bool> filter)
    {
        try
        {
            return _dal.Customer.Read(c => filter(c.Convert())).Convert();
        }
        catch (BlDoesNotExistException ex)
        {
            throw new BlDoesNotExistException("customer for Read doesnt found");
        }
    }

    public List<BO.Customer?> ReadAll(Func<BO.Customer, bool>? filter = null)
    {
        try
        {
            if (filter == null)
                return _dal.Customer.ReadAll().Select(c => c.Convert()).ToList();
            return _dal.Customer.ReadAll(c => filter(c.Convert())).Select(c => c.Convert()).ToList();
        }
        catch (Exception ex)
        {
            throw new Exception("");
        }
    }
    public  void Update(BO.Customer item)
    {
        try
        {
           _dal.Customer.Update(item.Convert());
        }
        catch (BlDoesNotExistException ex)
        {
            throw new BlDoesNotExistException("customer for Update doesnt found");
        }
    }
    public void Delete(int id)
    {
        try
        {
            _dal.Customer.Delete(id);
        }
        catch (BlDoesNotExistException ex)
        {
            throw new BlDoesNotExistException("customer for delete doesnt found");
        }

    }
    public bool Exists(int id)
    {
        try
        {
             _dal.Customer.Read(id);
              return true;
        }
        catch (BlDoesNotExistException ex)
        {
           return false;
        }
    }



}
