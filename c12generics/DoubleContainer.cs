using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c12generics
{
    internal class DoubleContainer
    {
        public double Value { get; private set; }
        public DoubleContainer(double value)
        {
            Value = value;
        }
        public double SetValue(double value)
        {
            Value = (double)value;
            return Value;
        }

        public double Increment(double value)
        {
            Value += value;
            return Value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
