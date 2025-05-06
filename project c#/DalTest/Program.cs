using DalApi;
using DO;
using Tools;
using System.Reflection;

namespace DalTest
{
    internal class Program
    {
        static readonly IDal s_dal = DalApi.Factory.Get;
        static void Main(string[] args)
        {
            try { Initalization.Initialize(); }
            catch {
                Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name,"Initialize error");
                throw new Exception("error"); }

            Console.WriteLine("Do you want to initialize? \n press yes else press no");
            string s = Console.ReadLine();
            if (s == "yes")
                DalTest.Initalization.Initialize();

            int select = printMainMenu();
            while (select != 0)
            {
                switch (select)
                {
                    case 1:
                        productMenu();
                        break;
                    case 2:
                        saleMenu();
                        break;
                    case 3:
                        customerMenu();
                        break;
                    case 4:
                        clearLog();
                        break;
                    default:
                        Console.WriteLine("Wrong selection, please select again");
                        break;
                }
                select = printMainMenu();
            }
        }
        private static void clearLog()
        {
          LogManager.ClearLog();
        }
        private static void productMenu()
        {
            int select = printSubMenu("product");
            while (select != 0)
            {
                switch (select)
                {
                    case 1:
                        CreateProduct(s_dal.Product);
                        break;
                    case 2:
                        Read<Product>(s_dal.Product);
                        break;
                    case 3:
                        ReadAll<Product>(s_dal.Product);
                        break;
                    case 4:
                        UpdateProduct(s_dal.Product);
                        break;
                    case 5:
                        Delete<Product>(s_dal.Product);
                        break;
                    default:
                        Console.WriteLine("Wrong selection, please select again");
                        break;
                }
                select = printSubMenu("product");
            }
        }
        private static void saleMenu()
        {
            int select = printSubMenu("sale");
            while (select != 0)
            {
                switch (select)
                {
                    case 1:
                        CreateSale(s_dal.Sale);
                        break;
                    case 2:
                        Read<Sale>(s_dal.Sale);
                        break;
                    case 3:
                        ReadAll<Sale>(s_dal.Sale);
                        break;
                    case 4:
                        UpdateSale(s_dal.Sale);
                        break;
                    case 5:
                        Delete<Sale>(s_dal.Sale);
                        break;
                    default:
                        Console.WriteLine("Wrong selection, please select again");
                        break;
                }
                select = printSubMenu("Sale");
            }
        }
        private static void customerMenu()
        {
            int select = printSubMenu("customer");
            while (select != 0)
            {
                switch (select)
                {
                    case 1:
                        CreateCustomer(s_dal.Customer);
                        break;
                    case 2:
                        Read<Customer>(s_dal.Customer);
                        break;
                    case 3:
                        ReadAll<Customer>(s_dal.Customer);
                        break;
                    case 4:
                        UpdateCustomer(s_dal.Customer);
                        break;
                    case 5:
                        Delete<Customer>(s_dal.Customer);
                        break;
                    default:
                        Console.WriteLine("Wrong selection, please select again");
                        break;
                }
                select = printSubMenu("Customer");
            }

        }

        private static int printMainMenu()
        {
            Console.WriteLine("For product press 1");
            Console.WriteLine("For sale press 2");
            Console.WriteLine("For customer press 3");
            Console.WriteLine("For clearing log press 4");
            Console.WriteLine("To exit press 0");

            int select;
            if (!int.TryParse(Console.ReadLine(), out select))
                select = -1;

            return select;
        }
        private static int printSubMenu(string item)
        {
            Console.WriteLine();
            Console.WriteLine($"To create {item} press 1");
            Console.WriteLine($"To read {item}  press 2");
            Console.WriteLine($"To readall {item}  press 3");
            Console.WriteLine($"To update {item}  press 4");
            Console.WriteLine($"To delete {item}  press 5");
            Console.WriteLine($"To go back press 0");

            int select;
            if (!int.TryParse(Console.ReadLine(), out select))
                select = -1;

            return select;
        }

        private static void ReadAll<T>(ICrud<T> crud)
        {
            foreach (var item in crud.ReadAll())
            {
                Console.WriteLine(item);
            }
        }
        private static void Read<T>(ICrud<T> crud)
        {
            Console.WriteLine("insert id ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine(crud.Read(id));
        }
        private static void Delete<T>(ICrud<T> crud)
        {
            Console.WriteLine("Delete id ");
            try
            {
                int id = int.Parse(Console.ReadLine());
                crud.Delete(id);
            }
            catch
            {
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "id is not defined");
            }

        }
        private static void CreateProduct(IProduct p)
        {
            Product item = InputProduct();
            p.Create(item);
        }
        private static void UpdateProduct(IProduct p)
        {
            Product item = InputProduct();
            p.Update(item);
        }

        private static Product InputProduct()
        {
            Console.WriteLine("enter product id");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("enter product name");
            string? name = Console.ReadLine();
            Console.WriteLine("choose product category:");
            foreach (Category c in Enum.GetValues(typeof(Category)))
            {
                Console.Write(c+" ,");
            }
            Console.WriteLine();
            string? category = Console.ReadLine();
            Enum.TryParse<Category>(category, true, out Category result);
            Console.WriteLine("enter product price");
            int? price = int.Parse(Console.ReadLine());
            Console.WriteLine("enter product quantity");
            int? quantity = int.Parse(Console.ReadLine());
            Product item = new Product(id, name, result, price, quantity);
            return item;
        }

        private static void CreateSale(ISale p)
        {
            Sale item = InputSale();
            p.Create(item);
        }
        private static void UpdateSale(ISale p)
        {
            Sale item = InputSale();
            p.Update(item);
        }

        private static Sale InputSale()
        {
            Console.WriteLine("enter Sale id");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("enter Sale productid");
            int? productid = int.Parse(Console.ReadLine());

            Console.WriteLine("enter Sale price");
            double? price = double.Parse(Console.ReadLine());

            Console.WriteLine("enter Sale quantity");
            int? quantity = int.Parse(Console.ReadLine());

            Console.WriteLine("enter Sale StartDate");
            DateTime? StartDate = DateTime.TryParse(Console.ReadLine(), out DateTime sd) ? (DateTime?)sd : null;

            Console.WriteLine("enter Sale FinishDate");
            DateTime? FinishDate = DateTime.TryParse(Console.ReadLine(), out DateTime fd) ? (DateTime?)fd : null;

            Console.WriteLine("enter Sale ifclub");
            bool? ifClub = bool.TryParse(Console.ReadLine(), out bool result) ? (bool?)result : null;
            Sale item = new Sale(id, productid, quantity, price, ifClub, sd, fd);
            return item;
        }

        private static void CreateCustomer(ICustomer p)
        {
            Customer item = InputCustomer();
            p.Create(item);
        }

        private static Customer InputCustomer()
        {
            Console.WriteLine("enter customer id");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("enter customer name");
            string name = Console.ReadLine();
            Console.WriteLine("enter customer phone");
            string phone = Console.ReadLine();
            Console.WriteLine("enter customer address");
            string address = Console.ReadLine();
            return new Customer(id, name, phone, address);
        }

        private static void UpdateCustomer(ICustomer p)
        {
            Customer item = InputCustomer();
            p.Update(item);
        }


    }
}