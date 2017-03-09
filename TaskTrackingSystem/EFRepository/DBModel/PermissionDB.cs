using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFRepository.DBModel
{
    public class PermissionDB : Entity
    {
        public PermissionDB()
        {
            Roles = new BindingList<RoleDB>();
        }
        public string Title { get; set; }
        public PermissionTypeDB Type { get; set; }
        public virtual BindingList<RoleDB> Roles { get; set; }
    }
}
