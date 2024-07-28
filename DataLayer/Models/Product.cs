using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using DataLayer.Models;

namespace DataLayer.Models
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string PictureUrl { get; set; }
        public decimal Price { get; set; }
        public int? Rate { get; set; } // Update [optinal]
        public Target Target { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }// Update
        public decimal? Discount { get; set; } // Update[optinal]

        public int Quantity { get; set; }

        [ForeignKey(nameof(ProductBrand))]
        public int ProductBrandId { get; set; }

        public ProductBrand ProductBrand { get; set; }

        [ForeignKey(nameof(ProductType))]

        public int ProductTypeyId { get; set; }

        public ProductType ProductType { get; set; }

        // Navigational property
        public virtual ICollection<Cart> Carts { get; set; } = new HashSet<Cart>();
        public virtual ICollection<Order> Orders { get; set; } = new HashSet<Order>();


    }
}