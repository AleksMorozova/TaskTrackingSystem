using System;
using System.Collections.Generic;
using System.Web.Http;
using Server.Models;

namespace Server.Controllers
{
    [RoutePrefix("api/categories")]
    public class CategoryController : ApiController
    {
        public CategoryController()
        {
            
        }

        [HttpGet]
        [Route("")]
        public IEnumerable<CategoryAPIModel> GetAllCategories()
        {
            return null;
        }

        [HttpPost]
        [Route("")]
        public void PostCategory([FromBody]CategoryAPIModel model)
        {

        }

        [HttpPut]
        [Route("")]
        public void PutCategory(Guid id, [FromBody]CategoryAPIModel model)
        {

        }

        [HttpDelete]
        [Route("")]
        public void DeleteCategory(Guid id)
        {

        }
    }
}
