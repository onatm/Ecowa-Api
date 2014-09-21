using Ecowa.Business;
using Ecowa.Model;
using Microsoft.WindowsAzure.Mobile.Service.Security;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace Ecowa.Api.Controllers
{
    [AuthorizeLevel(AuthorizationLevel.User)]
    [RoutePrefix("api/categories")]
    public class CategoryController : ApiController
    {
        private IEcowaBusiness _business;

        public CategoryController(IEcowaBusiness business)
        {
            _business = business;
        }

        [HttpGet]
        [Route("")]
        [ResponseType(typeof(IEnumerable<CategoryViewModel>))]
        public async Task<IHttpActionResult> GetCategories()
        {
            IEnumerable<CategoryViewModel> modelList = await Task.Run(() =>
            {
                return _business.Categories.GetAll();
            });

            return Ok(modelList);
        }
    }
}
