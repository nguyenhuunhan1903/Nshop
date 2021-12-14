using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Nshop.Models
{
    public partial class Admins
    {
        public string AdminId { get; set; }
        public string Username { get; set; }
        public string Userpassword { get; set; }
        public string FullName { get; set; }
    }
}
