
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
            if (product!=null&&product.Quantity - quantity < 0)
                throw new BlNotInStockException("no enough products");
            ProductInOrder result = order.ProductInOrders.FirstOrDefault(c => c.Id == productId);
            if (result == null)
            {
                order.ProductInOrders.Add(new ProductInOrder(productId, "", quantity, 0, 0));
            }
            else result.Quantity += quantity;
            ProductInOrder p = (ProductInOrder)order.ProductInOrders.Select(i => i.Id == productId);
            CalcTotalPriceForProduct(p);
            CalcTotalPrice(order);
            SearchSaleForProduct(p,order.Favorite);
            return p.SaleInProducts;         
        }
        
        catch (Exception ex)
        {
            throw new Exception();
        }
    }
    public void CalcTotalPriceForProduct(ProductInOrder product)
    {
        try
        {
            int? count = product.Quantity;
            List<SaleInProduct>s= new List<SaleInProduct>();    
            foreach (SaleInProduct i in product.SaleInProducts)
            {
                if (count == 0)
                    break;
                if (i.Quantity <= count)
                {
                    product.FinalPrice += count / i.Quantity * i.Price;
                    s.Add(i);
                    count -= count % i.Quantity;
                }
            }
            product.FinalPrice += product.BasePrice * count;
        }
        catch (Exception ex)
        {
            throw new Exception();
        }

    }
    public  void CalcTotalPrice(Order order)
    {
        try
        {
            order.ProductInOrders.Sum( c=>order.FinalPrice += c.FinalPrice);

        }
        catch (Exception ex) { throw new Exception(); }
    }
    public void DoOrder(Order order)
    {
        try
        {
            order.ProductInOrders.ForEach(i =>_dal.Product.Read(c=>c.productId==i.Id).Convert().Quantity-=i.Quantity);
        }
        catch (Exception ex) { throw new Exception(); }
    }
    public void SearchSaleForProduct(ProductInOrder product, bool favorite)
    {
        try
        {
            product.SaleInProducts = _dal.Sale.ReadAll(i => i.saleQuantity <= product.Quantity).Select(i => i.Convert())
                .Select(i => new SaleInProduct(i.SaleId, i.SaleQuantity, i.SalePrice, i.SaleIfClub)).OrderBy(s=>s.Price).ToList();

        }
        catch (Exception ex)
        {
            throw new Exception();
        }
    }

}
