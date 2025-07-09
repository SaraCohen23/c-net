

namespace BO;

public class Order
{
    public bool Favorite { get; set; }
    public double? FinalPrice { get; set; }
    public List<ProductInOrder> ProductInOrders { get; set; }
    public Order(bool favorite, double? finalPrice, List<ProductInOrder> productInOrders)
    {
        Favorite = favorite;
        FinalPrice = finalPrice;
        ProductInOrders = productInOrders ?? new List<ProductInOrder>();
    }
    public override string ToString() => this.ToStringProperty();
}
