﻿using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataLayer.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public DateTimeOffset OrderDate { get; set; }
        public OrderStatus Status { get; set; }
        public string Address { get; set; }
        public decimal TotalPrice { get; set; }

        public User UserId { get; set; }
        public virtual ICollection<Product> Products { get; set; } = new HashSet<Product>();
    }
}