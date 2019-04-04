using System;
using System.Collections.Generic;
using System.Text;
using Com.Umer.DataModel;

namespace Com.Umer.ViewModel
{
   public class CategoryViewModel:BaseViewModel<Category>
    {
        public CategoryViewModel(Category category):base(category)
        {
            Name = category.Name;

        }

        public string Name { get; set; }
    }
}
