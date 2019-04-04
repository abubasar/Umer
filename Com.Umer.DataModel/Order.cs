using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Com.Umer.DataModel
{
   public class Order:BaseEntity
    {
        public string Name { get; set; }
        public ICollection<CartLine> Products { get; set; }
        
        public string Address { get; set; }
        public string PaymentId { get; set; }
        [ForeignKey("PaymentId")]
        public Payment Payment { get; set; }
        public bool Shipped { get; set; } = false;

    }
}
