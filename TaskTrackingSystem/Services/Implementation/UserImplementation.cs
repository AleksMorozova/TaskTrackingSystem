using AutoMapper;
using DomainModel;
using EFRepository.DBModel;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implementation
{
    public class UserImplementation : IUserContract
    {
        public void SaveUser(DomainModel.User user)
        {
            UserDB createdUser = new UserDB();

            Mapper.Map<User, UserDB>(user);

            Registration.UserRepository.Create(createdUser);
        }

        public List<User> GetAllUsers() { return new List<User>(); }
        public User GetUserByLogin(string login) { return new User(); }
    }
}
