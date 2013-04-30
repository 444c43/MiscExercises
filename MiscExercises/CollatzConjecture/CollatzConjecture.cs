using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscExercises
{
    public class CollatzConjecture
    {
        # region fields

        /// <summary>
        /// generated sequence listing from seed number
        /// </summary>
        public List<long> Sequence { get; private set; }
        #endregion

        #region constructors
        /// <summary>
        /// default parameter value is 1
        /// </summary>
        public CollatzConjecture() 
        {
            BuildConjectureList(2);
        }
        
        /// <summary>
        /// enter starting number to calculate
        /// </summary>
        /// <param name="initialNum"></param>
        
        public CollatzConjecture(long initialNum)
        {
            Sequence = new List<long>();
            BuildConjectureList(initialNum);
        }
        #endregion

        #region accesible method
        /// <summary>
        /// enter new seed number to calculate
        /// </summary>
        /// <param name="seedNum"></param>
        public void EnterNewSeedNumber(long seedNum)
        {
            Sequence.Clear();
            BuildConjectureList(seedNum);
        }
        #endregion

        #region private methods
        private void BuildConjectureList(long currentNum)
        {
            // Termination condition
            // while (_SequenceShouldContine())
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
        #endregion
    }
}
