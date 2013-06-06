using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class BubbleSort : SortBaseClass
    {
        #region fields
        private bool IsSorted;
        #endregion

        #region constructors
        public BubbleSort()
        {
        }

        public BubbleSort(List<int> list)
        {
            base.SortedList = list;
            IsSorted = false;
        }
        #endregion

        public override void SortList()
        {
            while (!IsSorted)
            {
                IsSorted = true;
                IterateList();
            }
        }

        #region private methods
        private void IterateList()
        {
            for (int i = 0; i < base.SortedList.Count - 1; i++)
            {
                CompareMembers(i);
            }
        }

        private void CompareMembers(int i)
        {
            if (base.SortedList[i] > base.SortedList[i + 1])
            {
                base.SortedList.Reverse(i, 2);
                IsSorted = false;
            }
        }
        #endregion
    }
}