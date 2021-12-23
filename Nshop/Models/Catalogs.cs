using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Nshop.Models
{
    public partial class Catalogs
    {
        public Catalogs()
        {
            Products = new HashSet<Products>();
        }

        public string CatalogId { get; set; }
        public string CatalogName { get; set; }

        public virtual ICollection<Products> Products { get; set; }
    }
}
