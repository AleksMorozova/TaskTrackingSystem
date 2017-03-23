using System;
using System.ComponentModel;

namespace DomainModel
{
    public class Permission : Entity
    {
        public Permission()
        {
            Roles = new BindingList<Role>();
        }
        public string Title { get; set; }
        public PermissionType Type { get; set; }
        public virtual BindingList<Role> Roles { get; set; }
    }
}
