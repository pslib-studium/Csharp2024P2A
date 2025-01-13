using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c12generics
{
    internal class IntContainer
    {
        public int Value { get; private set; }
        public IntContainer(int value) {
            Value = value; }
        public int SetValue(int value) 
        {  
            Value = (int)value;
            return Value; 
        }

        public int Increment(int value)
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
