
using BlApi;
using BO;

namespace BlImplementation;

internal class OrderImplementation : IOrder
{
    private DalApi.IDal _dal = DalApi.Factory.Get;
    public List<SaleInProduct> AddProductToOrder(Order order, int productId, int quantity)
    {
        try
        {
            Product product = _dal.Product.Read(productId).Convert();
            if (product != null && product.Quantity - quantity < 0)
                throw new BlNotInStockException("no enough products");
            ProductInOrder result = order.ProductInOrders.FirstOrDefault(c => c.Id == productId);
            if (result == null)
            {
                order.ProductInOrders.Add(new ProductInOrder(productId, "", quantity, product.Price??0, 0));
            }
            else { result.Quantity += quantity; }
            product.Quantity -= quantity;
            _dal.Product.Update(product.Convert());
            ProductInOrder p = order.ProductInOrders.FirstOrDefault(i => i.Id == productId);
            SearchSaleForProduct(p, order.Favorite);
            double basep = CalcTotalPriceForProduct(p);
            order.FinalPrice -= basep;
            CalcTotalPrice(order, p);

            return p.SaleInProducts;
        }

        catch (BlNotInStockException ex)
        {
            throw new BlNotInStockException(ex.ToString());
        }
    }
    public double CalcTotalPriceForProduct(ProductInOrder product)
    {
        try
        {
            int? count = product.Quantity;
            List<SaleInProduct> s = new List<SaleInProduct>();
            double basep = product.FinalPrice ?? 0;
            product.FinalPrice = product.BasePrice * count;
            foreach (SaleInProduct i in product.SaleInProducts)
            {
                if (count == 0)
                    break;
                if (i.Quantity <= count)
                {
                    product.FinalPrice -= ((count - count % i.Quantity) * i.Price);
                    s.Add(i);
                }
            }
            product.SaleInProducts = s;
            return basep;
        }
        catch (Exception ex)
        {
            throw new Exception();
        }

    }
    public void CalcTotalPrice(Order order, ProductInOrder p)
    {
        try
        {
            order.FinalPrice += p.FinalPrice;

        }
        catch (Exception ex) { throw new Exception(); }
    }
    public void DoOrder(Order order)
    {
        try
        {
            order.ProductInOrders.ForEach(i => _dal.Product.Read(c => c.productId == i.Id).Convert().Quantity -= i.Quantity);
        }
        catch (Exception ex) { throw new Exception(); }
    }
    public void SearchSaleForProduct(ProductInOrder product, bool favorite)
    {
        try
        {
            product.SaleInProducts = _dal.Sale.ReadAll(i => i.saleQuantity <= product.Quantity &&
            product.Id == i.saleProductId && i.saleStartDate <= DateTime.Now && i.saleFinishDate >= DateTime.Now).Select(i => i.Convert())
                .Select(i => new SaleInProduct(i.SaleId, i.SaleQuantity, i.SalePrice, i.SaleIfClub)).OrderBy(s => s.Price).ToList();

        }
        catch (Exception ex)
        {
            throw new Exception();
        }
    }

}
