

using BO;

namespace BlApi;

public interface IProduct
{
    int Create(Product item); //Creates new entity object in DAL
    Product? Read(int id); //Reads entity object by its ID 
    Product? Read(Func<Product, bool> filter); // stage 2
    List<Product?> ReadAll(Func<Product, bool>? filter = null);  //stage 2
    void Update(Product item); //Updates entity object
    void Delete(int id); //Deletes an object by its Id
    void AllSales(ProductInOrder product, bool favorite);
}
