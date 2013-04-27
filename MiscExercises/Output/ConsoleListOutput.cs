using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Output
{
    // I think you have the right idea here.  You seem to be trying to capture
    // repeatable output tasks that will be used often, but there may be an SRP
    // violation here.  These tasks are really data preperation for output.  
    // Turning a list into a string with separators could be something 
    // I would to do without outputing it to the console.  I might want
    // to long the info, or display it on another type of window.  
    // I wouldn't want to have to rewrite the logic to produce the string.
    //
    // As the reqrites below suggest, it's tough to justify the existence of an
    // output library at the console level.  I think we'll find things are different
    // with Winforms and the Web.  Still, good work overall.
    class ConsoleListOutput
    {
        // I think what you want for a method name here is unbroken or wrapped right?
        // Maybe stream?  Also, the name should indicate output
        // If the list is very long, the results may not be on a single line.
        // I could also call this with the Environment.NewLine separator creating
        // the same effect.  See refactoring below.
        public static void SingleLine(List<long> list, string separator)
        {
            // Convention is to go with < and Count
            // for (int x = 0; x < list.Count; x++)
            // It just looks a little cleaner.
            // 
            // Also, convention for single character index is i rather than x
            // An index of 'index' might be better than i
            //
            // A foreach loop (since List is IEnumerable) might be even better
            for (int x = 0; x <= list.Count - 1; x++)
            {
                Console.Write(list[x]);
                if (x != list.Count - 1)
                {
                    // Strong assumption here with the space,
                    // since the user can provide whatever string they want.
                    Console.Write(separator + " ");
                }
            }

            // This is interesting, I'm not sure if the presence 
            // of the extra 'return' is implied.
            Console.WriteLine();
        }

        // Alternate implementation
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

        // Alternate implementation
        public static void WriteLines(long[] numbers)
        {
            Write(numbers, Environment.NewLine);
        }
    }
}
