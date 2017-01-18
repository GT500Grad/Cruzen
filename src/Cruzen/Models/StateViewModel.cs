using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cruzen.Models
{
    [Table("state", Schema = "dbo")]
    public class State
    {
        public int stateId { get; set; }
        public string Name { get; set; }
        public string Abbr { get; set; }

    }
}
