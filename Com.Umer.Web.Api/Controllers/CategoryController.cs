using Com.Umer.ApplicationService;
using Com.Umer.DataModel;
using Com.Umer.RequestModel;
using Com.Umer.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Com.Umer.Web.Api.Controllers
{
    [Route("api/category")]
    public class CategoryController : BaseController<Category, CategoryRequestModel, CategoryViewModel>
    {
        public CategoryController(IBaseService<Category, CategoryRequestModel, CategoryViewModel> service) : base(service)
        {
        }
    }
}