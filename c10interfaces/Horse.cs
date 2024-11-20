using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c10interfaces
{
    internal class Horse: Vehicle, IMeasurablePower, IAging
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
