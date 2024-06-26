﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPos.Models
{
    internal class Order
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public string OrdererName { get; set; } = string.Empty;
        public string OrdererAddress { get; set; } = string.Empty;
        public string ReceiverName { get; set; } = string.Empty;
        public string ReceiverAddress { get; set; } = string.Empty;
        public DateTime PlacedDate { get; set; }
        public bool IsPaid { get; set; }
        public int Payment { get; set; }
        public bool Confirmed { get; set; }
        public string Comment { get; set; } = string.Empty;
        public bool isCancel { get; set; } 
        public bool isRead {  get; set; }
    }
}
