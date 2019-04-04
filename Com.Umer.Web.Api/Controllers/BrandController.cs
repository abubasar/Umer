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
    [Route("api/brand")]
    public class BrandController : BaseController<Brand, BrandRequestModel, BrandViewModel>
    {
        public BrandController(IBaseService<Brand, BrandRequestModel, BrandViewModel> service) : base(service)
        {
        }
    }
}
