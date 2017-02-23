using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Issue
    {
        public Guid Id { get; set; }
        public string Number { get; set; }
        public string Specification { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime FinishDate { get; set; }
        public Priority Priority { get; set; }
        public Status Status { get; set; }
        public virtual Project Project { get; set; }
        public virtual User CurrentUser { get; set; }
        public virtual User Author { get; set; }
        public virtual Category Category { get; set; }
        public virtual List<History> Tasks { get; set; }
    }
}
