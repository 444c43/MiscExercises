using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Output;

namespace MiscExercises
{
    class MiscExercisesMain
    {
        static void Main(string[] args)
        {
            CollatzSolution();
        }
        static void DisplayResults()
        {
            Console.Write("Factorial of 7 = ");
            Console.WriteLine(FactorialRecursion.FindFactorial(7));
            Console.WriteLine("");

            ListManipulation.ListManipulationBegin();
            Console.WriteLine("");
        }
        static void CollatzSolution()
        {
            CollatzConjecture NewConjecture = new CollatzConjecture(6);

            NewConjecture.EnterNewSeedNumber(4);

            ConsoleListOutput.SingleLine(NewConjecture.Sequence, ",");
        }
    }
}
