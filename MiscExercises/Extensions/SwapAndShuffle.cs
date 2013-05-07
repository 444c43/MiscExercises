using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExtensions
{
    static class SimpleSwapAndShuffle
    {
        #region public methods
        /// <summary>
        /// swaps two list members between provided indices
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="firstIndex"></param>
        /// <param name="secondIndex"></param>
        /// <returns></returns>
        public static List<T> Swap<T>(this List<T> list,
            int firstIndex,
            int secondIndex)
        {
            if (IsWithinBounds<T>(list, firstIndex, secondIndex))
            {
                SwapListMembers<T>(list, firstIndex, secondIndex);
            }
            return list;
        }

        /// <summary>
        /// randomly shuffles a passed list
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public static List<T> Shuffle<T>(this List<T> list)
        {
            Random randomNum = new Random();

            for (int i = 0; i < list.Count; i++)
            {
                list.Swap(i, randomNum.Next(list.Count));
            }
            return list;
        }
        #endregion

        #region private methods
        private static void SwapListMembers<T>(List<T> list, int firstIndex, int secondIndex)
        {
            T temporarymember = list[firstIndex];
            list[firstIndex] = list[secondIndex];
            list[secondIndex] = temporarymember;
        }

        private static bool IsWithinBounds<T>(List<T> list, int firstIndex, int secondIndex)
        {
            return firstIndex >= 0 && firstIndex < list.Count &&
                            secondIndex >= 0 && secondIndex < list.Count;
        }
        #endregion
    }
}
