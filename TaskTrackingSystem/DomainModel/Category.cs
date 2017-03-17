using System;
using System.ComponentModel;


namespace DomainModel
{
    public class Category
    {
        public Guid Id { get; set; }
        public string CategoryTitle { get; set; }
        public string Type { get; set; }
        public string Addition { get; set; }
        public virtual BindingList<Project> Projects { get; set; }
    }
}
