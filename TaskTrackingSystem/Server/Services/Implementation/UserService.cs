using DomainModel;
using Server.Models;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Server.Services.Implementation
{
    public class UserService: IUserService
    {
        private readonly IUserContract _contract;

        public UserService(IUserContract contract)
        {
            _contract = contract;
        }
        public IEnumerable<UserAPIModel> GetAllUsers()
        {
            return _contract.GetAllUsers().Select(user => new UserAPIModel
            {
                Id = user.Id,
                FirstName = user.FirstName
            }).ToList();
        }

        public void AddUser(UserAPIModel userModel)
        {
            var addedUser = new User
            {
                FirstName = userModel.FirstName
            };

            _contract.AddUser(addedUser);
        }

        public void UpdateUser(UserAPIModel userModel)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(Guid userId)
        {
            throw new NotImplementedException();
        }
    }
}