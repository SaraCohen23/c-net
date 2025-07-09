using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{

    public record Product(
     int productId,
     string? productName,
     Category? productCategory, 
    int? quantity,
     double? price
    )
    {
        public Product() : this(1, "", Category.pizza, 0, 0)
        {

        }
    }

}
