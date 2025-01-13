using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace c12generics
{
    internal class Container<T> where T : INumber<T> // where T : class
    {
        public T Value { get; private set; }
        public Container(T value)
        {
            Value = value;
        }
        public T SetValue(T value)
        {
            Value = value;
            return Value;
        }

        public T Increment(T value)
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
