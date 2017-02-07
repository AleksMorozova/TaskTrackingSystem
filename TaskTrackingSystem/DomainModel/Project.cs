using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Project
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Number { get; set; }
        public string Description { get; set; }
        public virtual BindingList<User> Users { get; set; }
        public virtual BindingList<Task> Tasks { get; set; }
        public virtual BindingList<Category> Projects { get; set; }
    }
}
