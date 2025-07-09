
using DO;

namespace Dal;

internal static class DataSource
{
    internal static List<Product?> ProductsList = new List<Product?>();
    internal static List<Customer> CustomersList = new List<Customer>();
    internal static List<Sale> SalesList = new List<Sale>();

    internal static class Config
    {

        
        internal const int MINSALE = 0;
        private static int IdSale =MINSALE;
        public static int getSaleId => IdSale += 1;


        internal const int MINPRODUCT = 0;
        private static int IdProduct=MINPRODUCT;
        public static int getProductId=> IdProduct += 1;

     


    }
}
