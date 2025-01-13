using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c12generics
{
    internal class FloatContainer
    {
        public float Value { get; private set; }
        public FloatContainer(float value)
        {
            Value = value;
        }
        public float SetValue(float value)
        {
            Value = value;
            return Value;
        }

        public float Increment(float value)
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
