using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cruzen.Models
{
    [Table("status", Schema = "cruise")]
    public class Status
    {
        public int StatusId { get; set; }
        public string Name { get; set; }
        
    }
}
