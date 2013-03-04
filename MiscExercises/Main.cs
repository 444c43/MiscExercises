using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscExercises
{
    class MiscExercisesMain
    {
        static void Main(string[] args)
        {
            DisplayResults();
        }
        static void DisplayResults()
        {
            Console.Write("Factorial of 7 = ");
            Console.WriteLine(FactorialRecursion.FindFactorial(7));
            Console.WriteLine("");

            ListManipulation.ListManipulationBegin();
            Console.WriteLine("");
        }
    }
}
