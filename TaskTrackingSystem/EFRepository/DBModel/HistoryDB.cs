using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFRepository.DBModel
{
    public class HistoryDB : Entity
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public StatusDB Status { get; set; }
        public virtual UserDB AssignedUser { get; set; }
        public virtual IssueDB Task { get; set; }
        public string Note { get; set; }
    }
}
