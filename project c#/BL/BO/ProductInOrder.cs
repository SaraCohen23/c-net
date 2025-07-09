

namespace BO;

public class ProductInOrder
{
    public int Id { get; init; }
    public string Name { get; set; }
    public int Quantity { get; set; }
    public double BasePrice { get; set; }
    public double? FinalPrice { get; set; }
    public List<SaleInProduct>  SaleInProducts{ get; set; }

    public ProductInOrder(int id, string name, int quantity, double basePrice, double? finalPrice)
    {
        Id = id;
        Name = name;
        Quantity = quantity;
        BasePrice = basePrice;
        FinalPrice = finalPrice;
        SaleInProducts = new List<SaleInProduct>();
    }

    public override string ToString() => this.ToStringProperty();
}
