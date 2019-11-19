using System;
using System.Collections;
using System.Collections.Generic;

namespace TaxiApp.Models
{
    public class Client
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Email { get; set; }
        

        public virtual ICollection<Order> Orders { get; set; } = new List<Order>(); 
    }
}