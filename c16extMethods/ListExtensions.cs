using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c16extMethods
{
    internal static class ListExtensions
    {
        public static int CountOdd(this List<int> ints) // this =>>> this.op()
        {
            int i = 0;
            foreach (int j in ints)
            {
                if (j % 2 == 1)
                {
                    i++;
                }
            }
            return i;
        }
    }
}
