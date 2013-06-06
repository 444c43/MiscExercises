using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class InsertionSort : SortBaseClass
    {
        #region constructors
        public InsertionSort()
        {
        }

        public InsertionSort(List<int> list):base()
        {
            base.SortedList = list;
        }
        #endregion

        public override void SortList()
        {
            for (int index = 1; index < base.SortedList.Count; index++)
            {
                Insert(index);
            }
        }

        private void Insert(int index)
        {
            int value = base.SortedList[index];
            int i = index - 1;
            while (i >= 0 && value < base.SortedList[i])
            {
                base.SortedList.Reverse(i, 2);
                i -= 1;
            }
        }
    }
}
