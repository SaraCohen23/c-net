

namespace BO;

public class SaleInProduct
{
    public int Id { get; init; }
    public int? Quantity { get; set; }
    public double? Price { get; set; }
    public bool? IfAll { get; set; }

    public SaleInProduct(int id, int? quantity, double? price, bool? ifAll)
    {
        Id = id;
        Quantity = quantity;
        Price = price;
        IfAll = ifAll;
    }
    public override string ToString() => this.ToStringProperty();
}
