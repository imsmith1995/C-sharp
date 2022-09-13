﻿using System;
using System.Collections.Generic;

namespace LinqWithEfCore
{
    public partial class Vendor
    {
        public Vendor()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string City { get; set; } = null!;
        public string State { get; set; } = null!;
        public string Zip { get; set; } = null!;
        public string? Phone { get; set; }
        public string? Email { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
