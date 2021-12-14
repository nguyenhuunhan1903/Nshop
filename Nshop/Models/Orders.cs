using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Nshop.Models
{
    public partial class Orders
    {
        public string OrderId { get; set; }
        public string TransactionId { get; set; }
        public string ProductId { get; set; }
        public int? Quantity { get; set; }
        public bool? OrderStatus { get; set; }

        public virtual Products Product { get; set; }
        public virtual Transactions Transaction { get; set; }
    }
}
