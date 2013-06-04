using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscExercises
{
    public class FactorialRecursion
    {
        public static long FindFactorial(int val)
        {
            while (val > 1)
            {
                return val * FindFactorial(val - 1);
            }
            return 1;
        }
    }
}
