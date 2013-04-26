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
            //6 = 6,3,10,5,16,8,4,2,1
            CollatzConjecture NewConjecture = new CollatzConjecture(6);
            
            ConsoleListOutput.SingleLine(NewConjecture.Sequence, ",");
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
