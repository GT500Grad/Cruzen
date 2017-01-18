using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cruzen.Models
{
    [Table("location", Schema = "cruise")]
    public class Location
    {
        public int LocationId { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }

        public int StateId { get; set;  }
        public State State { get; set; }

        public decimal Lat { get; set; }
        public decimal Long { get; set; }

        //public List<Post> Posts { get; set; }
    }
}
