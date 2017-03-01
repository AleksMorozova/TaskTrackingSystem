using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFRepository.DBModel
{
    public class RoleDB : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual BindingList<PermissionDB> Permissions { get; set; }
    }
}
