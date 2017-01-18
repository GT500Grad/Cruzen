using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cruzen.Models
{
    [Table("cruise", Schema = "cruise")]
    public class Cruise
    {
        public int CruiseId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPhone { get; set; }
        public DateTime UpdateDate { get; set; }

        public DateTime CruiseDate { get; set; }
        public TimeSpan CruiseStart { get; set; }
        public TimeSpan CruiseEnd { get; set; }
        //public DateTime RainDate { get; set; }
        public string Cost { get; set; }

        public int LocationId { get; set;  }
        public Location Location { get; set; }
        public int TypeId { get; set; }
        public Type Type { get; set; }
        public int StatusId { get; set; }
        public Status Status { get; set; }
        public int AccountId { get; set; }
        //public 

        //public List<Post> Posts { get; set; }
    }
}
