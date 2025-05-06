

using BlApi;
using BO;

namespace BlImplementation;

internal class ProductImplementation : IProduct
{
    private DalApi.IDal _dal = DalApi.Factory.Get;

    public int Create(BO.Product item)
    {
        try
        {
            return _dal.Product.Create(item.Convert());
        }
        catch (BlExistsAlreadyException ex)
        {
            throw new BlExistsAlreadyException("product for creation exists already");
        }
    }
    public BO.Product? Read(int id)
    {

        try
        {
            return _dal.Product.Read(id).Convert();
        }
        catch (BlDoesNotExistException ex)
        {
            throw new BlDoesNotExistException("product for Read doesnt found");
        }
    }
    public BO.Product? Read(Func<BO.Product, bool> filter)
    {
        try
        {
            return _dal.Product.Read(c => filter(c.Convert())).Convert();
        }
        catch (BlDoesNotExistException ex)
        {
            throw new BlDoesNotExistException("product for read doesnt found");
        }
    }
    /// <summary>
    ///       //איזו שגיאה לתפוס
    /// </summary>
    /// <param name="filter"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public List<BO.Product?> ReadAll(Func<BO.Product, bool>? filter = null)
    {
        try
        {
            if (filter == null)
                return _dal.Product.ReadAll().Select(c => c.Convert()).ToList();
            //return _dal.Product.ReadAll().Select(c => c.Convert<DO.Product>()).Where(filter).ToList();
            return _dal.Product.ReadAll(c => filter(c.Convert())).Select(c => c.Convert()).ToList();
        }
 
        catch (Exception ex)
        {
            throw new Exception("");
        }
    }
    public void Update(BO.Product item)
    {
        try
        {
            _dal.Product.Update(item.Convert());
        }
        catch (BlDoesNotExistException ex)
        {
            throw new BlDoesNotExistException("product for update doesnt found");
        }
    }
    public void Delete(int id)
    {
        try
        {
            _dal.Product.Delete(id);
        }
        catch (BlDoesNotExistException ex)
        {
            throw new BlDoesNotExistException("product for delete doesnt found");
        }

    }
    public void AllSales(ProductInOrder product, bool favorite)
    {
        product.SaleInProducts.ForEach(i => Console.WriteLine(i));
    }
}
