using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExtensions
{
    static class PrimeNumberSieve
    {
        /// <summary>
        /// sieves composite numbers from a list of type long
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static List<long> SieveComposites(this List<long> list)
        {
            int offset_index = 0;
            while (offset_index < list.Count)
            {
                RemoveNumbers(list, list[offset_index]);
                offset_index += 1;
            }
            return list;
        }

        private static List<long> RemoveNumbers(this List<long> list, long denominator)
        {
            for (int index = 0; index < list.Count; index++)
            {
                if (list[index] % denominator == 0)
                {
                    list.RemoveAt(index);
                }
            }
            return list;
        }
    }
}
