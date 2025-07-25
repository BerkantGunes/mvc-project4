﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrika.Data.Model
{
    public class PurchaseOrder
    {
        public int PurchaseOrderId { get; set; }
        public int SupplierId { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; } // e.g., Pending, Delivered
        public Supplier Supplier { get; set; }
    }
}
