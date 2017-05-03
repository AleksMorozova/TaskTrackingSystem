using DomainModel;
using System;
using System.Collections.Generic;

namespace Services.Contracts
{
    public interface IUserContract
    {
        void AddUser(User user);
        IEnumerable<User> GetAllUsers();
        User GetUserByLogin(string login);
        User GetUserByID(Guid ID);
    }
}
