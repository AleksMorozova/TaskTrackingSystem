using System;

namespace DomainModel
{
    public class History : Entity
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Status Status { get; set; }
        public virtual User AssignedUser { get; set; }
        public virtual Issue Issue { get; set; }
        public string Note { get; set; }
    }
}
