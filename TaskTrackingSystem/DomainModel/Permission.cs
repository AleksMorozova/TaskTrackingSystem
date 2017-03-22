using System;
using System.ComponentModel;

namespace DomainModel
{
    public class Permission : Entity
    {
        public string Title { get; set; }
        public PermissionType Type { get; set; }
        public virtual BindingList<Role> Roles { get; set; }
    }
}
