using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Nshop.Models
{
    public partial class Users
    {
        public Users()
        {
            Transactions = new HashSet<Transactions>();
        }

        public string Userid { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string YourAddress { get; set; }
        public string UserPassword { get; set; }
        public DateTime? CreateDay { get; set; }

        public virtual ICollection<Transactions> Transactions { get; set; }
    }
}
