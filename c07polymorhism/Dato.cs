using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c07polymorhism
{
    internal class Dato: object
    {
        public Dato(int value)
        {
            Value = value;
        }

        public int Value { get; set; }
        public virtual int Add(int value)  // polymorphism 1.type = oveloading
        {
            Console.WriteLine("Dato");
            return Value += value;
        }

        public int Add(float value)
        {
             return Value += (int)value;
        }

        public int Add(string value)
        {
            return Value += int.Parse(value);
        }
        public override string ToString()
        {
            return "> " + Value.ToString();
        }
    }
}
