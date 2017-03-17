using System;

namespace Server.Models
{
    public class CategoryAPIModel
    {
        public Guid Id { get; set; }
        public string CategoryTitle { get; set; }
        public string Type { get; set; }
        public string Addition { get; set; }
    }
}