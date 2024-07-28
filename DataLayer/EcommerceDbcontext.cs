using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Drawing.Printing;

namespace DataLayer
{
    public class EcommerceDbcontext : DbContext
    {
        public EcommerceDbcontext() : base("EcommerceDb")
        {


        }

        public DbSet<Models.Product> Products { get; set; }
        public DbSet<Models.ProductType> ProductTypes { get; set; }
        public DbSet<Models.ProductBrand> ProductBrands { get; set; }

        public DbSet<Models.Order> Orders { get; set; }
        public DbSet<Models.Cart> Cart { get; set; }

        public DbSet<Models.User> Users { get; set; }

    }
}