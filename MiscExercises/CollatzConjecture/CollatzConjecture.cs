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
        
        // Tell me about the motivations behind this constructor.
        // Perhaps...
        // public CollatzConjecture() : this(1) { }
        // This would help ensure the Sequence property doesn't return null
        //public CollatzConjecture() { }
        
        // Your comment about this code being 'tightly copupled' is
        // unclear.  I read the SRP of this class as 
        // Calculate the hailstone sequence for a given number.
        // That's what the code seems to be doing.
        //
        // You mentioned something about 'limiting the object' use in
        // your email.  I imagine you would use it whenever you need to do
        // this calculation.
        //
        // If you wanted to consider reusability you might consider refactoring a base
        // class from this one which provides structure for any terminating sequence
        // construction.  One could then inject into this base class the logic for
        // determining a sequence. I can imagine a couple pieces of such a refactoring,
        // and I have included comments below that show those pieces.
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

                // Next number in sequence
                // _CalculateNextNumberInSequence(currentNum);
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

        //private long _CalculateNextNumberInSequence(int currentNum)
        //{
        //    // Here you would determine the next number.
        //    // Would this be restricted to sequences made of integers?
        //}

        //private bool _ShouldSequenceCalculationContinue(int currentNum)
        //{
        //    // Here you would query the termination condition that has been injected.
        //}
    }
}
