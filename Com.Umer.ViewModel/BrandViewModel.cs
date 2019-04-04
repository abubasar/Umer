using System;
using System.Collections.Generic;
using System.Text;
using Com.Umer.DataModel;

namespace Com.Umer.ViewModel
{
    public class BrandViewModel:BaseViewModel<Brand>
    {
        public BrandViewModel(Brand brand):base(brand)
        {
            Name = brand.Name;

        }
        public string Name { get; set; }
    }
}
