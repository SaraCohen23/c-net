
namespace BO;

public class Product
{
    public int ProductId { get; init; }
    public string? ProductName { get; set; }
    public Category? ProductCategory  { get; set; }
    public int? Quantity { get; set; }
    public double? Price { get; set; }
    public List<SaleInProduct> SaleInProduct { get; set; }

    public Product(int productId, string? productName, Category? productCategory,
                  int? quantity, double? price)
    {
        ProductId = productId;
        ProductName = productName;
        ProductCategory = productCategory;
        Quantity = quantity;
        Price = price;
        SaleInProduct = new List<SaleInProduct>();
    }
    public override string ToString() => this.ToStringProperty();

}
