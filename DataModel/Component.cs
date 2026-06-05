using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class Component
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public ObservableCollection<Port> Ports { get; set; }

        public Component() 
        {
            Ports = new ObservableCollection<Port>();
        }
    }
}
