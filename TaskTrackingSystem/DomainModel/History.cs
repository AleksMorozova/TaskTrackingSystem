using System;

namespace DomainModel
{
    public class History
    {
        public Guid Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Status Status { get; set; }
        public virtual User AssignedUser { get; set; }
        public virtual Issue Task { get; set; }
        public string Note { get; set; }
    }
}
