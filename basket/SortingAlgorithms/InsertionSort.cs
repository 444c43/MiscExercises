using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class InsertionSort
    {
        #region fields
        public List<int> SortedList { get; private set; }
        #endregion

        #region constructors
        public InsertionSort()
        {
        }

        public InsertionSort(List<int> list)
        {
            SortedList = list;
        }
        #endregion

        public void SortList()
        {
            IterateList(SortedList);
        }

        private List<int> IterateList(List<int> list)
        {
            for (int index = 1; index < list.Count; index++)
            {
                int value = list[index];
                int i = index - 1;
                while (i >= 0 && value < list[i])
                {
                    list.Reverse(i, 2);
                    i -= 1;
                }
            }
            return list;
        }
    }
}
