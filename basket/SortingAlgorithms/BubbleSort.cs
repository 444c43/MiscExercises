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
        public List<int> SortedList {get; private set;}
        private bool IsSorted;
        #endregion

        #region constructor
        public BubbleSort()
        {
        }

        public BubbleSort(List<int> list)
        {
            SortedList = list;
            IsSorted = false;
        }
        #endregion

        public List<int> SortList()
        {
            while (!IsSorted)
            {
                IsSorted = true;
                IterateList();
            }
            return SortedList;
        }

        #region private methods
        private void IterateList()
        {
            for (int i = 0; i < SortedList.Count - 1; i++)
            {
                CompareMembers(i);
            }
        }

        private void CompareMembers(int i)
        {
            if (SortedList[i] > SortedList[i + 1])
            {
                SortedList.Reverse(i, 2);
                IsSorted = false;
            }
        }
        #endregion
    }
}