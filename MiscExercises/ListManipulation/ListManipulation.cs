using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscExercises
{
    public class ListManipulation
    {
        public static void ListManipulationBegin()
        {
            List<int> originalList = new List<int>(CreateList());
            List<int> newList = GetValuesLessThan(3, originalList);
            List<int> newListReversed = ReverseList(newList);

            ListDisplay("Original list: ", originalList);
            ListDisplay("New list (less than values): ", newList);
            ListDisplay("New list reversed: ", newListReversed);
        }

        private static List<int> CreateList()
        {
            List<int> GenerateList = new List<int>();
            for (int x = 0; x <= 5; x++)
            {
                GenerateList.Add(x);
            }
            return GenerateList;
        }

        private static void ListDisplay(string action_description, List<int> value)
        {
            Console.Write(action_description);
            for (int y = 0; y <= value.Count - 1; y++)
            {
                Console.Write(value[y]);
            }
            Console.WriteLine();
        }

        private static List<int> GetValuesLessThan(int value, List<int> input)
        {
            List<int> lessThanValues = new List<int>();
            for (int i = 0; i <= input.Count - 1; i++)
            {
                if (input[i] < value)
                    lessThanValues.Add(input[i]);
            }

            return lessThanValues;
        }

        private static List<int> ReverseList(List<int> input)
        {
            List<int> ReversedList = new List<int>();

            for (int x = input.Count - 1; x >= 0; x--)
            {
                ReversedList.Add(input[x]);
            }

            return ReversedList;
        }
    }
}
