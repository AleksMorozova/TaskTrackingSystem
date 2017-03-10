using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFRepository.DBModel
{
    public class UserDB : Entity
    {
        public UserDB()
        {
            Projects = new BindingList<ProjectDB>();
            Roles = new BindingList<RoleDB>();
        }
        [Required]
        public string Login { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual BindingList<ProjectDB> Projects { get; set; }
        public virtual BindingList<RoleDB> Roles { get; set; }
    }
}