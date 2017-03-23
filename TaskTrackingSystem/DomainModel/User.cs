using System;
using System.ComponentModel;

namespace DomainModel
{
    public class User : Entity
    {
        public User()
        {
            Projects = new BindingList<Project>();
            Roles = new BindingList<Role>();
        }
        public string Login { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual BindingList<Project> Projects { get; set; }
        public virtual BindingList<Role> Roles { get; set; }
    }
}
