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
        /// default parameter value is 4
        /// </summary>
        public CollatzConjecture() :this(4){}
        
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
            while (ShouldCalculationContinue(currentNum))
            {
                Sequence.Add(currentNum);

                currentNum = CalculateNextSequenceNum(currentNum);
            }
            Sequence.Add(1);
        }

        private long CalculateNextSequenceNum(long testValue)
        {
            long result;
            if (testValue % 2 == 0)
            {
                result = testValue / 2;
            }
            else
            {
                result = (testValue * 3) + 1;
            }
            return result;
        }

        private bool ShouldCalculationContinue(long evaluatedNum)
        {
            return evaluatedNum > 1;
        }
        #endregion
    }
}
