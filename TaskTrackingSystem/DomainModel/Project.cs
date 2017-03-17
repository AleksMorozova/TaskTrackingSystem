using System;
using System.ComponentModel;

namespace DomainModel
{
    public class Project
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Number { get; set; }
        public string Description { get; set; }
        public virtual BindingList<User> Users { get; set; }
        public virtual BindingList<Issue> Tasks { get; set; }
        public virtual BindingList<Category> Projects { get; set; }
    }
}
