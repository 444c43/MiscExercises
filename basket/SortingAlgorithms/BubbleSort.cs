using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class BubbleSort
    {
        #region fields
        private List<int> SortedList;
        private bool IsSorted;
        public int PassCount { get; private set; }
        #endregion

        #region constructor
        public BubbleSort()
        {
            SortedList = new List<int>();
            IsSorted = false;
            PassCount = 0;
        }
        #endregion

        public List<int> SortList(List<int> list)
        {
            SortedList = list;

            while (IsSorted == false)
            {
                IsSorted = true;
                IterateList();
                PassCount++;
            }
            return SortedList;
        }

        #region private methods
        private void IterateList()
        {
            for (int i = 1; i < SortedList.Count; i++)
            {
                CompareListMembers(i);
            }
        }

        private void CompareListMembers(int i)
        {
            if (SortedList[i] < SortedList[i - 1])
            {
                SortedList.Reverse(i - 1, 2);
                IsSorted = false;
            }
        }
        #endregion
    }
}