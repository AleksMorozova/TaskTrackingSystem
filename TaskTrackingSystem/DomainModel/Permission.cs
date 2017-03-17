using System;
using System.ComponentModel;

namespace DomainModel
{
    public class Permission
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public PermissionType Type { get; set; }
        public virtual BindingList<Role> Roles { get; set; }
    }
}
