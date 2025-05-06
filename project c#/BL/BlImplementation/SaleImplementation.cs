

using BlApi;
using BO;

namespace BlImplementation;

internal class SaleImplementation:ISale
{
    private DalApi.IDal _dal = DalApi.Factory.Get;

    public int Create(BO.Sale item)
    {
        try
        {
            return _dal.Sale.Create(item.Convert());
        }
        catch (BlExistsAlreadyException ex)
        {
            throw new BlExistsAlreadyException("Sale for creation exists already");
        }
    }
    public BO.Sale? Read(int id)
    {

        try
        {
            return _dal.Sale.Read(id).Convert();
        }
        catch (BlDoesNotExistException ex)
        {
            throw new BlDoesNotExistException("Sale for Read doesnt found");
        }
    }
    public BO.Sale? Read(Func<BO.Sale, bool> filter)
    {
        try
        {
            return _dal.Sale.Read(c => filter(c.Convert())).Convert();
        }
        catch (BlDoesNotExistException ex)
        {
            throw new BlDoesNotExistException("Sale for Read doesnt found");
        }
    }

    public List<BO.Sale?> ReadAll(Func<BO.Sale, bool>? filter = null)
    {
        try
        {
            if (filter == null)
                return _dal.Sale.ReadAll().Select(c => c.Convert()).ToList();
            //return _dal.Sale.ReadAll().Select(c => c.Convert<DO.Sale>()).Where(filter).ToList();
            return _dal.Sale.ReadAll(c => filter(c.Convert())).Select(c => c.Convert()).ToList();
        }
        catch (Exception ex)
        {
            throw new Exception("");
        }
    }
    public void Update(BO.Sale item)
    {
        try
        {
            _dal.Sale.Update(item.Convert());
        }
        catch (BlDoesNotExistException ex)
        {
            throw new BlDoesNotExistException("Sale for Read doesnt found");
        }
    }
    public void Delete(int id)
    {
        try
        {
            _dal.Sale.Delete(id);
        }
        catch (BlDoesNotExistException ex)
        {
            throw new BlDoesNotExistException("Sale for delete doesnt found");
        }

    }
}
