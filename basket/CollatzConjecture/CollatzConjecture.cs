using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitBasket
{
    public class CollatzConjecture
    {
        # region fields
        /// <summary>
        /// generated sequence listing from seed number
        /// </summary>
        public List<long> Sequence { get; private set; }
        public long SeedNumber { get; private set; }
        #endregion

        #region constructors
        /// <summary>
        /// default parameter value is 4
        /// </summary>
        public CollatzConjecture() :this(4){}
        
        /// <summary>
        /// enter starting number to calculate
        /// </summary>
        /// <param name="seed_number"></param>
        
        public CollatzConjecture(long seed_number)
        {
            Sequence = new List<long>();
            BuildHailstoneList(seed_number);
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
            BuildHailstoneList(seedNum);
        }
        #endregion

        #region private methods
        private void BuildHailstoneList(long currentNum)
        {
            while (currentNum > 1)
            {
                Sequence.Add(currentNum);

                currentNum = CalculateNextSequenceNum(currentNum);
            }
            Sequence.Add(1);
        }

        private long CalculateNextSequenceNum(long current_num)
        {
            if (current_num % 2 == 0)
            {
                current_num = current_num / 2;
            }
            else
            {
                current_num = (current_num * 3) + 1;
            }
            return current_num;
        }
        #endregion
    }
}
