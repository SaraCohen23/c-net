
using BlApi;
using BO;

namespace BlImplementation;

internal class OrderImplementation : IOrder
{
    private DalApi.IDal _dal = DalApi.Factory.Get;
    public List<SaleInProduct> AddProductToOrder(Order order, int productId, int quantity,double price)
    {
        try
        {
            Product product = _dal.Product.Read(productId).Convert();
            if (product!=null&&product.Quantity - quantity < 0)
                throw new BlNotInStockException("no enough products");
            ProductInOrder result = order.ProductInOrders.FirstOrDefault(c => c.Id == productId);
            if (result == null)
            {
                order.ProductInOrders.Add(new ProductInOrder(productId, "", quantity, price, 0));
            }
            else { result.Quantity += quantity;  }
            product.Quantity-=quantity;
            _dal.Product.Update(product.Convert());
            ProductInOrder p = order.ProductInOrders.FirstOrDefault(i => i.Id == productId);
            SearchSaleForProduct(p, order.Favorite);
            double basep=CalcTotalPriceForProduct(p,order.Favorite);
            CalcTotalPrice(order,p.FinalPrice??0,basep);
        
            return p.SaleInProducts;         
        }
        
        catch (BlNotInStockException ex)
        {
            throw new BlNotInStockException(ex.ToString());
        }
    }
    public double CalcTotalPriceForProduct( ProductInOrder product ,bool favorite)
    {
        try
        {
            int? count = product.Quantity;
            List<SaleInProduct>s= new List<SaleInProduct>();
            double base_price = product.FinalPrice ?? 0;
            foreach (SaleInProduct i in product.SaleInProducts)
            {
                if (i.IfAll == false || favorite)
                {
                    if (count == 0)
                        break;
                    if (i.Quantity <= count)
                    {
                        product.FinalPrice = product.BasePrice *( count - count % i.Quantity)-( count / i.Quantity * i.Price);
                        s.Add(i);
                        count =count%i.Quantity;
                    }
                }
            }           
            product.FinalPrice = product.BasePrice * count;
            return base_price;
        }
        catch (Exception ex)
        {
            throw new Exception();
        }

    }
    public  void CalcTotalPrice(Order order, double finalPrice,double basep)
    {
        try
        {
            order.FinalPrice+=finalPrice-basep;

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
            product.SaleInProducts = _dal.Sale.ReadAll(i => i.saleQuantity <= product.Quantity&&
            product.Id==i.saleProductId&&i.saleStartDate<=DateTime.Now&&i.saleFinishDate>=DateTime.Now).Select(i => i.Convert())
                .Select(i => new SaleInProduct(i.SaleId, i.SaleQuantity, i.SalePrice, i.SaleIfClub)).OrderBy(s=>s.Price).ToList();

        }
        catch (Exception ex)
        {
            throw new Exception();
        }
    }

}
