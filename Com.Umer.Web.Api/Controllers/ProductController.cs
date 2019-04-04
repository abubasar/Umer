using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Com.Umer.ApplicationService;
using Com.Umer.DataModel;
using Com.Umer.RequestModel;
using Com.Umer.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Com.Umer.Web.Api.Controllers
{
  

    namespace Com.Umer.Web.Api.Controllers
    {
        [Route("api/product")]
        public class ProductController : BaseController<Product, ProductRequestModel, ProductViewModel>
        {
            public ProductController(IBaseService<Product,ProductRequestModel, ProductViewModel> service) : base(service)
            {
            }
        }
    }
}
