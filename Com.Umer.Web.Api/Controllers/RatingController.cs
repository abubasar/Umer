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
    [Route("api/rating")]
    public class RatingController : BaseController<Rating, RatingRequestModel, RatingViewModel>
    {
        public RatingController(IBaseService<Rating, RatingRequestModel, RatingViewModel> service) : base(service)
        {
        }
    }
}