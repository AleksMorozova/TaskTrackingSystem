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
            _userService.AddUser(model);
        }

        [HttpPut]
        [Route("")]
        public void PutUser([FromBody]UserAPIModel model)
        {
            _userService.UpdateUser(model);
        }

        [HttpDelete]
        [Route("")]
        public void DeleteUser(Guid id)
        {
            _userService.DeleteUser(id);
        }
    }
}
