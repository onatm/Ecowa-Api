using Ecowa.Model;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace Ecowa.Api.Controllers
{
    [AllowAnonymous]
    [RoutePrefix("api/categories")]
    public class CategoryController : ApiController
    {
        [HttpGet]
        [Route("")]
        [ResponseType(typeof(IEnumerable<CategoryViewModel>))]
        public async Task<IHttpActionResult> GetCategories()
        {
            IEnumerable<CategoryViewModel> modelList = await Task.Run(() =>
            {
                return new List<CategoryViewModel> { new CategoryViewModel { Id = "category_id", Name = "category_name" } };
            });

            return Ok(modelList);
        }
    }
}
