using DomainModel;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services.Implementation
{
    public class UserImplementation : IUserContract
    {
        public void AddUser(User user)
        {
            Registration.UserRepository.Create(user);
        }

        public IEnumerable<User> GetAllUsers()
        {
            return Registration.UserRepository.ReadAll().ToList();
        }

        public User GetUserByLogin(string login)
        {
            return Registration.UserRepository.ReadAll().FirstOrDefault(_ => _.Login == login);
        }

        public User GetUserByID(Guid userId)
        {
            return Registration.UserRepository.Read(userId);
        }
    }
}
