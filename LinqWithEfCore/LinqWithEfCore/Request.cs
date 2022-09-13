﻿using System;
using System.Collections.Generic;

namespace LinqWithEfCore
{
    public partial class Request
    {
        public Request()
        {
            RequestLines = new HashSet<RequestLine>();
        }

        public int Id { get; set; }
        public string Description { get; set; } = null!;
        public string Justification { get; set; } = null!;
        public string? RejectionReason { get; set; }
        public string DeliveryMode { get; set; } = null!;
        public string Status { get; set; } = null!;
        public decimal Total { get; set; }
        public int UserId { get; set; }

        public virtual User User { get; set; } = null!;
        public virtual ICollection<RequestLine> RequestLines { get; set; }
    }
}
