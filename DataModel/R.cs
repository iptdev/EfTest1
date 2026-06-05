using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class R 
    {
        public Guid Id { get; set; }
        public int Value { get; set; }

        public R() { Id = Guid.NewGuid(); }
    }
}
