using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Project
{
   public class Customer
    {
        public string CustomerID { get; set; }
        public string ContactName { get; set; }
        public int OrderCount {
            get { return Orders.Count; }
                
                }

        public List<Order> Orders { get; set; }
    }
}
