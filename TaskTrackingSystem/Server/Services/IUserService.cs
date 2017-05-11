using Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Server.Services
{
    public interface IUserService
    {
        IEnumerable<UserAPIModel> GetAllUsers();
        void AddUser(UserAPIModel userModel);
        void UpdateUser(UserAPIModel userModel);
        void DeleteUser(Guid userId);
    }
}