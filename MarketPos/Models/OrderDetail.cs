using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPos.Models
{
    public class OrderDetail
    {
        public int productID { get; set; }
        public int quantity { get; set; }
        public int orderID { get; set; }
        public bool confirmed { get; set; }
    }
}
