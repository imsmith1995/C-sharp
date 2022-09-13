﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindLinq.Models
{
    public class Supplier
    {
        public int SupplierId { get; set; }
        public string CompanyName { get; set; } = string.Empty;
        public string? ContactName { get; set; }
        public string? ContactTitle { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? Region { get; set; }
        public string? PostalCode { get; set; }
        public string? Country { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }
        public string? HomePage { get; set; }

        public string VitalInfo()
        {
            return $"SupplierId     :   {SupplierId}\n" +
                   $"CompanyName    :   {CompanyName}\n" +
                   $"Country        :   {Country}\n";
        }
    }
}
