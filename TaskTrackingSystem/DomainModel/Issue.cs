using System;
using System.ComponentModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DomainModel
{
    public class Issue : Entity
    {
        public Issue()
        {
            Histories = new BindingList<History>();
        }
        public string Number { get; set; }
        public string Specification { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime FinishDate { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public Priority Priority { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public Status Status { get; set; }
        public virtual Project Project { get; set; }
        public virtual User CurrentUser { get; set; }
        public virtual User Author { get; set; }
        public virtual Category Category { get; set; }
        public virtual BindingList<History> Histories { get; set; }
    }
}
