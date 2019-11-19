using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TaxiApp.Models
{
    public class Order
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public OrderState OrderState { get; set; } = OrderState.Searching;
        public Location StartPosition { get; set; }
        public Location EndPosition { get; set; }

        public virtual Driver Driver { get; set; }
        public virtual Client Client { get; set; }
    }
}
