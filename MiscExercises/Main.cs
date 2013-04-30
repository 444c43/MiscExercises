using System;
using MiscExercises;
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
            ListManipulation.ListManipulationBegin();
            EquilibriumSolution();
            FactorialSolution();
        }

        private static void FactorialSolution()
        {
            int integer = 4;
            long result = FactorialRecursion.FindFactorial(integer);
            Console.WriteLine("{0}! = {1}", integer, result);
        }

        static void CollatzSolution()
        {
            CollatzConjecture NewConjecture = new CollatzConjecture(27);
            ConsoleListOutput.DisplayListSingleLineWrap(NewConjecture.Sequence, ", ");
            Console.WriteLine();
            Console.WriteLine("Total sequence count: {0}", NewConjecture.Sequence.Count);
            Console.WriteLine();
        }

        static void EquilibriumSolution()
        {
            int[] TestArray = new int[] { -7, 1, 5, 2, -4, 3, 0 };
            
            int EquilibriumIndice = Equilibrium.FindFirstEquilibrium(TestArray);
            Console.WriteLine("Equilibrium indice: {0}", EquilibriumIndice);
        }
    }
}
