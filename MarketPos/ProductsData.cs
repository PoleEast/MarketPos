﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MarketPos
{
    public class ProductsData
    {
        public string Name { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string Description { get; set; } = string.Empty;
        public double Weight { get; set; }
        public DateTime ShelveDate { get; set; }
        public string Origin { get; set; } = string.Empty;
        public int Stock { get; set; }
    }
}