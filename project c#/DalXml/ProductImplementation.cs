

using DalApi;
using DalXml;
using DO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Security.Claims;
using System.Xml.Linq;
using Tools;

namespace Dal;

internal class ProductImplementation : IProduct
{

    public static string filePath = @"../xml/products.xml";

    public int Create(Product item)
    {
        int id = Config.ProductId;
        Product product = item with { productId = id };
        XElement productXml = XElement.Load(filePath);
        LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Create Product");
        int n;
        if (productXml.Descendants("ArrayOfProduct")
            .Any(c => int.TryParse(c.Element("ProductId")?.Value, out n) && n == item.productId))
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "there is such item already");
            throw new DalExistsAlreadyException("product exists already");
        }

        productXml.Add(new XElement("Product",
         new XElement("ProductId", product.productId),
         new XElement("ProductName", product.productName),
         new XElement("ProductCategory", product.productCategory),
         new XElement("Quantity", product.quantity),
         new XElement("Price", product.price)
         ));

        LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Create Product");
        productXml.Save(filePath);
        return product.productId;
    }


    public Product? Read(int id)
    {
        XElement productXml = XElement.Load(filePath);
        LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read Product");
        int n;
        XElement p = productXml.Descendants("ProductId").FirstOrDefault(p => p.Value == id.ToString()).Parent;
        if (p == null)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "id not found");
            throw new DalDoesNotExistException("id not found ,Product");
        }
        Product product = new Product((int)(p.Element("ProductId")), p.Element("ProductName").Value,
            (Category)Enum.Parse(typeof(Category), p.Element("ProductCategory").Value), (int)p.Element("Quantity"), (double)p.Element("Price"));
        LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read Product");
        productXml.Save(filePath);
        return product;
    }
    public Product? Read(Func<Product, bool> func)
    {
        XElement productXml = XElement.Load(filePath);
        LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read Product");
        if (func == null)
        {
            throw new Exception("func is null");
        }
        int n;

        IEnumerable<Product> l = productXml.Descendants("Product").Select(p =>
        new Product((int)(p.Element("ProductId")),
        p.Element("ProductName").Value,
            (Category)Enum.Parse(typeof(Category), p.Element("ProductCategory").Value),
            (int)p.Element("Quantity"), (double)p.Element("Price")));
        Product p = l.FirstOrDefault(func);
        if (p == null)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "id not found");
            throw new DalDoesNotExistException("id not found ,Product");
        }
        LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read Product");
        productXml.Save(filePath);
        return p;
    }
    public List<Product> ReadAll(Func<Product, bool> func)
    {
        XElement productXml = XElement.Load(filePath);
        LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read Product");
        if (func == null)
        {
            throw new Exception("func is null");
        }
        int n;
        IEnumerable<Product> products = productXml.Descendants("Product").Select(p =>
        new Product((int)(p.Element("ProductId")),
        p.Element("ProductName").Value,
            (Category)Enum.Parse(typeof(Category), p.Element("ProductCategory").Value),
            (int)p.Element("Quantity"), (double)p.Element("Price")));
        productXml.Save(filePath);
        return (func == null) ? products.ToList() : products.Where(func).ToList();

    }
    public void Update(Product item)
    {
        XElement productXml = XElement.Load(filePath);
        LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "update Product");
        IEnumerable<Product> productsCopy = productXml.Descendants("Product").Select(p =>
         new Product((int)(p.Element("ProductId")),
         p.Element("ProductName").Value,
             (Category)Enum.Parse(typeof(Category), p.Element("ProductCategory").Value),
             (int)p.Element("Quantity"), (double)p.Element("Price")));
        foreach (var item2 in productsCopy)
        {
            if (item.productId == item2.productId)
            {
                Delete(item.productId);
                productXml.Add(item);
                productXml.Save(filePath);
                LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "update Product");
                return;
            }

        }
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "id not found");
        throw new DalDoesNotExistException("there is no such item ,product");

    }
    public void Delete(int id)
    {
        XElement productXml = XElement.Load(filePath);
        LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Delete Product");
        LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Delete Product");
        productXml.Descendants("Product").First(pId => pId.Value == id.ToString()).Parent.Remove();
        productXml.Save(filePath);
    }
}
