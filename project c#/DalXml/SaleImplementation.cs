
using DalApi;
using DalXml;
using DO;
using System.Reflection;
using System.Xml.Serialization;
using Tools;

namespace Dal;

internal class SaleImplementation : ISale
{
    XmlSerializer serializer = new XmlSerializer(typeof(List<Sale>));
    string xmlFilePath = @"../xml/Sales.xml";

    public List<Sale> load()
    {
        using (StreamReader sr = new StreamReader(xmlFilePath))
        {
            return serializer.Deserialize(sr) as List<Sale>;
        }
    }

    public void save(List<Sale> l)
    {
        using (StreamWriter sw = new StreamWriter(xmlFilePath))
        {
            serializer.Serialize(sw, l);
        }
    }
    public int Create(Sale item)
    {
        int id = Config.SaleId;
        Sale sale = item with { saleId=id};
        LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "create sale");
        List<Sale> list = load();
        list.Add(sale);
        save(list);
        LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "create sale");

        return sale.saleId;

    }

    public void Delete(int id)
    {
        LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "delete sale");

        List<Sale> list = load();

        Sale sale = list.FirstOrDefault(item => item.saleId == id);
        if (sale == null)
            throw new DalDoesNotExistException("id not found,sale");
        list.Remove(sale);
        save(list);

        LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "delete sale");

    }

    public Sale? Read(int id)
    {
        LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read sale");
        List<Sale> list = load();

        LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read sale");

       Sale sale= list.FirstOrDefault(item => item.saleId == id);
        if (sale == null)
            throw new DalDoesNotExistException("id not found,sale");
        return sale;
    }

    public Sale? Read(Func<Sale, bool> filter)
    {
        Sale sale = null;
        LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read sale");

        List<Sale> list = load();

        LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read sale");

        if (filter != null)
        {
            sale = list.FirstOrDefault(filter);
            if (sale == null)
                throw new DalDoesNotExistException("id not found,sale");
            return sale;
        }
        throw new DalFuncIsNullException("func is null, Sale");
    }

    public List<Sale?> ReadAll(Func<Sale, bool>? filter = null)
    {
        LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "readAll sale");
        List<Sale> list = load();

        LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "readAll sale");

        if (filter != null)
        {
            List<Sale> l = list.Where(filter).ToList();
            return l;
        }
        return list;
    }

    public void Update(Sale item)
    {
        LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "update sale");

        List<Sale> list = load();

        Sale sale = list.Find(i => i.saleId == item.saleId);
        if (sale == null)
            throw new DalDoesNotExistException("id not found,sale");

        Sale updatedSale = sale with
        {
            saleProductId = item.saleProductId,
            saleQuantity = item.saleQuantity,
            salePrice = item.salePrice,
            saleIfClub = item.saleIfClub,
            saleStartDate = item.saleStartDate,
            saleFinishDate = item.saleFinishDate
        };

        int index = list.IndexOf(sale);
        list[index] = updatedSale;

        save(list);
        LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "update sale");
    }
}
