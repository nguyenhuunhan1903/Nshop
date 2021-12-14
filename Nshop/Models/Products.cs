using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Nshop.Models
{
    public partial class Products
    {
        public Products()
        {
            Orders = new HashSet<Orders>();
        }
        [Key]
        public string ProductId { get; set; }
        public string CatalogId { get; set; }
        public string ProductName { get; set; }
        public decimal? Price { get; set; }
        public string Descriptions { get; set; }
        public int? Discount { get; set; }
        public string ImageLink { get; set; }
        public int? Quantity { get; set; }
        public string Detail { get; set; }

        public virtual Catalogs Catalog { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
