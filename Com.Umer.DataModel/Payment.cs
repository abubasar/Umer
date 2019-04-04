using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Umer.DataModel
{
   public class Payment:BaseEntity
    {
        
        public string CardNumber { get; set; }
        
        public string CardExpiry { get; set; }
        
        public int CardSecurityCode { get; set; }
       
        public decimal Total { get; set; }
        
        public string AuthCode { get; set; }
    }
}
