using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cruzen.Models
{
    [Table("type", Schema = "cruise")]
    public class Type
    {
        public int TypeId { get; set; }
        public string Name { get; set; }
        
    }
}
