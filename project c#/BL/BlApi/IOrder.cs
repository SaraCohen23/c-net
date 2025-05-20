using BO;

namespace BlApi;

public interface IOrder
{
    List<SaleInProduct> AddProductToOrder(Order order, int productId, int quantity, double price);
    void CalcTotalPrice(Order order, double finalPrice, double basep);

     double CalcTotalPriceForProduct(ProductInOrder product, bool favorite);

    void DoOrder(Order order);
    void SearchSaleForProduct(ProductInOrder product, bool favorite);

}
