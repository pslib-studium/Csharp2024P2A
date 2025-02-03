using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c16extMethods
{
    internal class ListDerivate: List<int>
    {
        public int CountOdd()
        {
            int i = 0;
            foreach (int j in this)
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
