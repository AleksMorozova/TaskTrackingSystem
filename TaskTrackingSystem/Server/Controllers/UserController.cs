using System;
using System.Collections.Generic;
using System.Web.Http;
using Server.Models;
using Server.Services;

namespace Server.Controllers
{
    [RoutePrefix("api/users")]
    public class UserController : ApiController
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        [Route("")]
        public IEnumerable<UserAPIModel> GetAllUsers()
        {
            return _userService.GetAllUsers();
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
