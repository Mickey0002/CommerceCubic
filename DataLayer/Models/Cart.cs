﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;
using Microsoft.AspNet.Identity;


namespace DataLayer.Models
{

    public class Cart : BaseEntity
    {
        public decimal TotalPrice { get; set; }
        public bool IsEmpty { get; set; }
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        // Navigational property
        public virtual ICollection<Product> Products { get; set; } = new HashSet<Product>();
    }
}
