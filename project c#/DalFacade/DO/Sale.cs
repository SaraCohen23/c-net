using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
        public record Sale(
            int saleId,
            int? saleProductId,
            int? saleQuantity,
            double? salePrice,
            bool? saleIfClub,
            DateTime? saleStartDate,
            DateTime? saleFinishDate

        )
        {
            public Sale() : this(0, 0, 0, 0, false, DateTime.Now, DateTime.Now)
            {

            }
        }


    
}
