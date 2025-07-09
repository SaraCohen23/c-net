

namespace BO;

public class Sale
{

    public int SaleId { get; init; }
    public int? SaleProductId { get; set; }
    public int? SaleQuantity { get; set; }
    public double? SalePrice { get; set; }
    public bool? SaleIfClub { get; set; }
    public DateTime? SaleStartDate { get; set; }
    public DateTime? SaleFinishDate { get; set; }

   
    public Sale(int saleId, int? saleProductId, int? saleQuantity,
                        double? salePrice, bool? saleIfClub,
                        DateTime? saleStartDate, DateTime? saleFinishDate)
    {
        this.SaleId = saleId;
        this.SaleProductId = saleProductId;
        this.SaleQuantity = saleQuantity;
        this.SalePrice = salePrice;
        this.SaleIfClub = saleIfClub;
        this.SaleStartDate = saleStartDate;
        this.SaleFinishDate = saleFinishDate;
    }

    public override string ToString() => this.ToStringProperty();
}
