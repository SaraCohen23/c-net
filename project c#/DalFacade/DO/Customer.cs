using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    
        public record Customer(
            int customerId,
            string? customerName,
            string? address,
            string? phone
            )
        {
            public Customer() : this(0, "", "", "")
            {

            }
        }
  
}
