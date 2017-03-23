using System;
using System.ComponentModel;

namespace DomainModel
{
    public class Project : Entity
    {
        public Project()
        {
            Users = new BindingList<User>();
            Issues = new BindingList<Issue>();
            Categories = new BindingList<Category>();
        }
        public string Title { get; set; }
        public string Number { get; set; }
        public string Description { get; set; }
        public virtual BindingList<User> Users { get; set; }
        public virtual BindingList<Issue> Issues { get; set; }
        public virtual BindingList<Category> Categories { get; set; }
    }
}
