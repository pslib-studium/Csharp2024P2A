using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c10interfaces
{
    internal class Car: Vehicle, IMeasurablePower
    {
        public string SPZ { get; set; }
        public int Speed { get; set; }
    }
}
