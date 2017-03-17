using System;
using System.Collections.Generic;
using System.Web.Http;
using Server.Models;

namespace Server.Controllers
{
    [RoutePrefix("api/users")]
    public class UserController : ApiController
    {
        public UserController()
        {

        }

        [HttpGet]
        [Route("")]
        public IEnumerable<UserAPIModel> GetAllUsers()
        {
            return null;
        }

        [HttpPost]
        [Route("")]
        public void PostUser([FromBody]UserAPIModel model)
        {

        }

        [HttpPut]
        [Route("")]
        public void PutUser(Guid id, [FromBody]UserAPIModel model)
        {

        }

        [HttpDelete]
        [Route("")]
        public void DeleteUser(Guid id)
        {

        }
    }
}
