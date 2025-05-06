using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace DalXml;

internal static class Config
{
    private static string filePath = @"../xml/data-config.xml";

    private static int saleId;

	public static int SaleId
    {
		get {
            XElement saleXml = XElement.Load(filePath);
			int num;
			if (!int.TryParse(saleXml.Value, out num))
				throw new Exception("didnt succeed to parse");			
			saleXml.SetValue(num +1);
			saleXml.Save(filePath);
            return num;
        }
		
	}

    private static int productId;

    public static int ProductId
    {
        get
        {
            XElement ProductXml = XElement.Load(filePath);
            int num;
            if (!int.TryParse(ProductXml.Value, out num))
                throw new Exception("didnt succeed to parse");
            ProductXml.SetValue(num + 1);
            ProductXml.Save(filePath);
            return num;
        }

    }

}
