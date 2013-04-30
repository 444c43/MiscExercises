using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Output
{
    class ConsoleListOutput
    {
        /// <summary>
        /// prints to console, including a separator (characters and spaces)
        /// </summary>
        /// <param name="list"></param>
        /// <param name="separator"></param>
        public static void WrapSingleLine<T>(List<T> list, string separator)
        {
            for (int index = 0; index < list.Count; index++)
            {
                Console.Write(list[index]);
                if (index != list.Count - 1)
                {
                    Console.Write(separator);
                }
            }
            Console.WriteLine();
        }

        public static void Write(long[] numbers, string seperator)
        {
            Console.Write(string.Join(seperator, numbers));
        }

        public static void MultiLine(List<long> list)
        {
            for (int x = 0; x <= list.Count - 1; x++)
            {
                Console.WriteLine(list[x]);
            }
        }
        
        public static void WriteLines(long[] numbers)
        {
            Write(numbers, Environment.NewLine);
        }
    }
}
