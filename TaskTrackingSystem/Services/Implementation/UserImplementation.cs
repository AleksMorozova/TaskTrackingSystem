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
            Registration.UserRepository.Create(Mapper.Map<User, UserDB>(user));
        }

        public List<User> GetAllUsers()
        {
            List<User> resultUsersList = new List<User>();
            Registration.UserRepository.ReadAll().ToList()
                .ForEach(user => resultUsersList.Add(Mapper.Map<UserDB, User>(user)));
            return resultUsersList;
        }
        public User GetUserByLogin(string login)
        {
            UserDB resultUser = Registration.UserRepository.ReadAll()
                .Where(_=>_.Login == login).FirstOrDefault();
            return Mapper.Map<UserDB, User>(resultUser);
        }

        public User GetUserByID(Guid ID)
        {
            return Mapper.Map<UserDB, User>(Registration.UserRepository.Read(ID));
        }
    }
}
