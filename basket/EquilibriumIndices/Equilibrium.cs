using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitBasket
{
    public class Equilibrium
    {
        public static int FindFirstEquilibrium(int[] A)
        {
            long RightSide = A.Sum();
            long LeftSide = 0;

            return CalculateEquilibrium(A, ref RightSide, ref LeftSide);
        }

        private static int CalculateEquilibrium(int[] A, ref long RightSide, ref long LeftSide)
        {
            for (int index = 0; index < A.Length; index++)
            {
                RightSide -= A[index];

                if (RightSide == LeftSide)
                {
                    return index;
                }
                LeftSide += A[index];
            }
            return -1;
        }
    }
}
