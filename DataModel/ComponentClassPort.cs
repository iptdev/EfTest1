using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class ComponentClassPort
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }

        [ForeignKey("ComponentId")]
        public required ComponentClass Component { get; set; }
        public required Guid ComponentId { get; set; }


    }
}
