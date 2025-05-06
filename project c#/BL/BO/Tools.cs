
using System.Reflection;
using System.Text;

namespace BO;

internal static class Tools
{
    public static string ToStringProperty<T>(this T obj)
    {
        StringBuilder sb = new StringBuilder();

        Type type = obj.GetType(); 
        foreach (PropertyInfo prop in type.GetProperties())
        {
                sb.AppendLine($"{prop.Name}= {prop.GetValue(obj)}");         
        }
        return sb.ToString();
    }
    public static DO.Customer Convert(this BO.Customer customer)
    {
        return new DO.Customer(customer.CustomerId,customer.CustomerName,customer.Adress,customer.Phone);
    }
    public static BO.Customer Convert(this DO.Customer customer)
    {
        return new BO.Customer(customer.customerId, customer.customerName, customer.address, customer.phone);
    }
    public static DO.Product Convert(this BO.Product Product)
    {
        return new DO.Product(Product.ProductId, Product.ProductName,(DO.Category)Product.ProductCategory,Product.Quantity, Product.Price);
    }
    public static BO.Product Convert(this DO.Product Product)
    {
        return new BO.Product(Product.productId, Product.productName, (BO.Category)Product.productCategory, Product.quantity, Product.price);    }

    public static DO.Sale Convert(this BO.Sale sale)
    {
        return new DO.Sale(sale.SaleId,sale.SaleProductId,sale.SaleQuantity,sale.SalePrice,sale.SaleIfClub,sale.SaleStartDate,sale.SaleFinishDate);
    }
    public static BO.Sale Convert(this DO.Sale sale)
    {
        return new BO.Sale(sale.saleId, sale.saleProductId, sale.saleQuantity, sale.salePrice, sale.saleIfClub, sale.saleStartDate, sale.saleFinishDate);
    }

}
