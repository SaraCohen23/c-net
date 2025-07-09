using DalApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    internal sealed class  DalList:IDal
    {
        public static DalList Instance;
        public ICustomer Customer => new CustomerImplement();

        public IProduct Product => new ProductImplement();

        public ISale Sale => new SaleImplement();

        private DalList() {
            Instance=new DalList();
        }
    }
}
