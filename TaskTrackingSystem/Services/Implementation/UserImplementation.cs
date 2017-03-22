using AutoMapper;
using DomainModel;
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
        public void SaveUser(User user)
        {
            Registration.UserRepository.Create(user);
        }

        public List<User> GetAllUsers()
        {
            return Registration.UserRepository.ReadAll().ToList();
        }

        public User GetUserByLogin(string login)
        {
            return Registration.UserRepository.ReadAll()
                .Where(_ => _.Login == login).FirstOrDefault();
        }

        public User GetUserByID(Guid userId)
        {
            return Registration.UserRepository.Read(userId);
        }
    }
}
