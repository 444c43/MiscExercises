using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscExercises
{
    class CollatzConjecture
    {
        public List<long> Sequence { get; private set; }
        
        public CollatzConjecture() { }
        
        public CollatzConjecture(long initialNum)
        {
            Sequence = new List<long>();
            BuildConjectureList(initialNum);
        }

        private void BuildConjectureList(long currentNum)
        {
            while (currentNum > 1)
            {
                Sequence.Add(currentNum);
                currentNum = CalculateConjecture(currentNum);
            }
            Sequence.Add(1);
        }

        private long CalculateConjecture(long currentNum)
        {
            long result;
            if (currentNum % 2 == 0)
            {
                result = currentNum / 2;
            }
            else
            {
                result = (currentNum * 3) + 1;
            }
            return result;
        }
    }
}
