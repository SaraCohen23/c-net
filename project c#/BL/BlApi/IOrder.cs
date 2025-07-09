using BO;

namespace BlApi;

public interface IOrder
{
    List<SaleInProduct> AddProductToOrder(Order order, int productId, int quantity);
    double CalcTotalPriceForProduct(ProductInOrder product);
    void CalcTotalPrice(Order order, ProductInOrder p);
    void DoOrder(Order order);
    void SearchSaleForProduct(ProductInOrder product, bool favorite);

}
