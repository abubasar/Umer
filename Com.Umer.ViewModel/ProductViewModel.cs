using System;
using System.Collections.Generic;
using System.Text;
using Com.Umer.DataModel;

namespace Com.Umer.ViewModel
{
  public  class ProductViewModel:BaseViewModel<Product>
    {
        public ProductViewModel(Product product):base(product)
        {
            Image = product.Image;
            Name = product.Name;
            if (Category != null)
            {
                this.Category=new CategoryViewModel(product.Category);
            }

            if (Brand != null)
            {
                this.Brand=new BrandViewModel(product.Brand);
            }

           
        }
        public string Image { get; set; }
        public string Name { get; set; }

      
        public CategoryViewModel Category { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public BrandViewModel Brand { get; set; }
        public List<RatingViewModel> Ratings { get; set; }
    }
}
