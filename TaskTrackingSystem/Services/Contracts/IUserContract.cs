using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface IUserContract
    {
        void SaveUser(User user);
        List<User> GetAllUsers();
        User GetUserByLogin(string login);
    }
}
