using System;
using System.Collections.Generic;

namespace Com.Umer.DataModel
{
    public class Category:BaseEntity
    {
        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
