using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Com.Umer.DataModel
{
   public class Brand:BaseEntity
    {
        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }


    }
}
