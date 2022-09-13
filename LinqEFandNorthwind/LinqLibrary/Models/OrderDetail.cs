﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindLinqEFLibrary.Models
{
    public class OrderDetail
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public float Discount { get; set; }

        public override string ToString()
        {
            return $"Order Detail:  {OrderId}   |   {ProductId} |   {UnitPrice} |   {Quantity}  |   {Discount}";
        }
    }
}
