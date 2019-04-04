using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;
using System.Text;

namespace Com.Umer.DataModel
{
    public class Product : BaseEntity
    {

        public string Image { get; set; }
        public string Name { get; set; }
        public string CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string BrandId { get; set; }
        [ForeignKey("BrandId")]
        public Brand Brand { get; set; }
        public List<Rating> Ratings { get; set; }
    }
}
