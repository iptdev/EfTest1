using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class ComponentClass
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public virtual ObservableCollection<ComponentClassPort> Ports { get; private set; }

        public ComponentClass() 
        {
            Ports = new ObservableCollection<ComponentClassPort>();
        }
    }
}
