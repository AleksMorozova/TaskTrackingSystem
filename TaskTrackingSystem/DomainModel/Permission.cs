using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
