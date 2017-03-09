using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFRepository.DBModel
{
    public class CategoryDB : Entity
    {
        public CategoryDB()
        {
            Projects = new BindingList<ProjectDB>();
        }
        public string CategoryTitle { get; set; }
        public string Type { get; set; }
        public string Addition { get; set; }
        public virtual BindingList<ProjectDB> Projects { get; set; }
    }
}
