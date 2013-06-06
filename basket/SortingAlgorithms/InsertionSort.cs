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
            for (int index = 1; index < SortedList.Count; index++)
            {
                Insert(index);
            }
        }

        private void Insert(int index)
        {
            int value = SortedList[index];
            int i = index - 1;
            while (i >= 0 && value < SortedList[i])
            {
                SortedList.Reverse(i, 2);
                i -= 1;
            }
        }
    }
}
