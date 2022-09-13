﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindLinq.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int? CustomerId { get; set; }//--------FK
        public int? EmployeeId { get; set; }//--------FK
        public DateTime? OrderDate { get; set; } 
        public DateTime? RequiredDate { get; set; } 
        public DateTime? ShippedDate { get; set; } 
        public int? ShipVia { get; set; }//-----------FK
        public decimal? Freight { get; set; }
        public string? ShipName { get; set; }
        public string? ShipAddress { get; set; }
        public string? ShipCity { get; set; }
        public string? ShipRegion { get; set; }
        public string? ShipPostalCode { get; set; }
        public string? ShipCountry { get; set; }
    }
}
