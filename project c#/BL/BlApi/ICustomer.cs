

using BO;

namespace BlApi;

public interface ICustomer
{
    int Create(Customer item); //Creates new entity object in DAL
    Customer? Read(int id); //Reads entity object by its ID 
    Customer? Read(Func<Customer, bool> filter); // stage 2
    List<Customer?> ReadAll(Func<Customer, bool>? filter = null);  //stage 2
    void Update(Customer item); //Updates entity object
    void Delete(int id); //Deletes an object by its Id
    bool Exists (int id);
}
