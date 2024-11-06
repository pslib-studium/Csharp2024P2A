using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c07polymorhism
{
    internal class ExtendedDato : Dato
    {
        public int Multiplier { get; set; } = 1;
        public ExtendedDato(int value) : base(value)
        {
        }

        // public new int Add(int value) - overloading, chová se podle vnějšího typu
        public override int Add(int value)
        {
            Console.WriteLine("ExtendedDato");
            return Value += value * Multiplier;
        }
    }
}
