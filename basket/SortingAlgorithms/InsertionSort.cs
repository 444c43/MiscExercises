using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class InsertionSort
    {
        public static List<int> IterateList(List<int> list)
        {
            for (int iterate = 1; iterate < list.Count; iterate++)
            {
                int value = list[iterate];
                int i = iterate - 1;
                while (i >= 0)
                {
                    if (value < list[i])
                    {
                        list.Reverse(i, 2);
                    }
                    i -= 1;
                }
            }
            return list;
        }
    }
}
