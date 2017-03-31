using DomainModel;
using System;
using System.Collections.Generic;

namespace Services.Contracts
{
    public interface IUserContract
    {
        void SaveUser(User user);
        List<User> GetAllUsers();
        User GetUserByLogin(string login);
        User GetUserByID(Guid ID);
    }
}
