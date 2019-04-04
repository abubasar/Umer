using System;
using System.Collections.Generic;
using System.Text;
using Com.Umer.DataModel;

namespace Com.Umer.ViewModel
{
    public class RatingViewModel:BaseViewModel<Rating>
    {
        public RatingViewModel(Rating rating):base(rating)
        {
            Stars = rating.Stars;
            if (rating.Product != null)
            {
                this.Product = new ProductViewModel(rating.Product);
            }
        }

        public int Stars { get; set; }

      
        public ProductViewModel Product { get; set; }
    }
}
