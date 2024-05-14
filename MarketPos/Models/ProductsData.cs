using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MarketPos.Models
{
    public class ProductsData
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string Description { get; set; } = string.Empty;
        public double Weight { get; set; }
        public DateTime ShelveDate { get; set; }
        public string Origin { get; set; } = string.Empty;
        public int Stock { get; set; }
        public bool IsShelve { get; set; }
        public bool Confirmed { get; set; }
    }
}
