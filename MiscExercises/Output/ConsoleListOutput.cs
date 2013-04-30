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
        /// writes each item to single line, including a separator (characters
        /// and spaces)
        /// </summary>
        /// <param name="list"></param>
        /// <param name="separator"></param>
        public static void DisplayListSingleLineWrap<T>(List<T> list, string separator)
        {
            for (int index = 0; index < list.Count; index++)
            {
                WriteList<T>(list, separator, index);
            }
            Console.WriteLine();
        }

        private static void WriteList<T>(List<T> list, string separator, int index)
        {
            Console.Write(list[index]);
            if (index != list.Count - 1)
            {
                Console.Write(separator);
            }
        }

        /// <summary>
        /// writes each item to new line
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        public static void DisplayListMultiLine<T>(List<T> list)
        {
            for (int x = 0; x <= list.Count - 1; x++)
            {
                Console.WriteLine(list[x]);
            }
        }
    }
}
