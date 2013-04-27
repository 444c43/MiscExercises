using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscExercises
{
    public class Equilibrium
    {
        public static int FindFirst(int[] A)
        {
            long RightSide = 0;
            foreach (int element in A)
            {
                RightSide += element;
            }
            long LeftSide = 0;

            for (int x = 0; x <= A.Length - 1; x++)
            {
                RightSide -= A[x];

                if (RightSide == LeftSide)
                {
                    return x;
                }
                LeftSide += A[x];
            }
            return -1;
        }
    }
}
