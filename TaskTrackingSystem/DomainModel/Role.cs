using System;
using System.ComponentModel;

namespace DomainModel
{
    public class Role
    {
        public Role()
        {
            Permissions = new BindingList<Permission>();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual BindingList<Permission> Permissions { get; set; }
    }
}
