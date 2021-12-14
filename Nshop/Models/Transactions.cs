using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Nshop.Models
{
    public partial class Transactions
    {
        public Transactions()
        {
            Orders = new HashSet<Orders>();
        }

        public string TransactionId { get; set; }
        public string Userid { get; set; }
        public decimal? Amount { get; set; }
        public string MessageT { get; set; }
        public DateTime? CreateDay { get; set; }
        public string Payment { get; set; }

        public virtual Users User { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
