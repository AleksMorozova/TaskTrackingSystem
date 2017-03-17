using System;
using System.ComponentModel;

namespace DomainModel
{
    public class User
    {
        public Guid Id { get; set; }
        public string Login { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual BindingList<Project> Projects { get; set; }
        public virtual BindingList<Role> Roles { get; set; }
    }
}
