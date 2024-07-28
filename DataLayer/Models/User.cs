using DataLayer.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;
using System.Data.Entity;
using System.Security.Claims;

namespace DataLayer.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual ICollection<Order> orders { get; set; } = new HashSet<Order>();
    }

    public class EcommerceDbcontext : IdentityDbContext<User>
    {
        public EcommerceDbcontext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static EcommerceDbcontext Create()
        {
            return new EcommerceDbcontext();
        }



    }
}
//namespace DataLayer.Models
//{
//    public class User : IdentityUser<int>


//    {
//        public string FirstName { get; set; }
//        public string LastName { get; set; }
//        public virtual ICollection<Order> orders { get; set; } = new HashSet<Order>();
//        // One-to-one relationship
//    }
//}