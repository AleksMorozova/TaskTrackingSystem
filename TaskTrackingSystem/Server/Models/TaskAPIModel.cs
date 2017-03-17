using System;

namespace Server.Models
{
    public class TaskAPIModel
    {
        public Guid Id { get; set; }
        public string Number { get; set; }
        public string Specification { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime FinishDate { get; set; }
        public string Priority { get; set; }
        public string Status { get; set; }
        public string ProjectName { get; set; }
        public string CurrentUserName { get; set; }
        public string AuthorName { get; set; }
        public string Category { get; set; }
    }
}