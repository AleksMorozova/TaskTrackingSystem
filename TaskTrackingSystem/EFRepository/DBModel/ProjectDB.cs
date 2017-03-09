using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFRepository.DBModel
{
    public class ProjectDB : Entity
    {
        public ProjectDB()
        {
            Categories = new BindingList<CategoryDB>();
            Issues = new BindingList<IssueDB>();
            Users = new BindingList<UserDB>();
        }
           
        [Required]
        public string Title { get; set; }
        [Required]
        public string Number { get; set; }
        public string Description { get; set; }
        public virtual BindingList<UserDB> Users { get; set; }
        public virtual BindingList<IssueDB> Issues { get; set; }
        public virtual BindingList<CategoryDB> Categories { get; set; }
    }
}
