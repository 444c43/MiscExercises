using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class SortBaseClass
    {
        #region fields
        public List<int> SortedList { get; protected set; }
        #endregion

        #region constructors
        public SortBaseClass()
        {
        }

        public SortBaseClass(List<int> list)
        {
            SortedList = list;
        }
        #endregion

        #region public methods
        public virtual void SortList()
        {
        }

        public void NewList(List<int> list)
        {
            SortedList.Clear();
            SortedList = list;
        }
        #endregion
    }
}
