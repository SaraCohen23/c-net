

namespace BO;

public class Customer
{
    public int CustomerId { get; init; }
    public string? CustomerName { get; set; }
    public string? Phone { get; set; }
    public string? Adress { get; set; }
    public Customer(int customerId, string? customerName, string? phone, string? adress)
    {
        CustomerId = customerId;
        CustomerName = customerName;
        Phone = phone;
        Adress = adress;
    }
    public override string ToString() => this.ToStringProperty();

}
