using System;

namespace NextSenseTasks
{

    internal class Solution
    {
        static void Main(string[] args)
        {
            // INTERVIEW TEST CASES
            Console.WriteLine(Interview(new int[] { 5, 5, 10, 10, 15, 15, 20, 20 }, 120));
            Console.WriteLine(Interview(new int[] { 2, 3, 8, 6, 5, 12, 10, 18 }, 64));
            Console.WriteLine(Interview(new int[] { 5, 5, 10, 10, 25, 15, 20, 20 }, 120));
            Console.WriteLine(Interview(new int[] { 5, 5, 10, 10, 15, 15, 20 }, 120));
            Console.WriteLine(Interview(new int[] { 5, 5, 10, 10, 15, 15, 20, 20 }, 130));

            // MINMOVES TEST CASES
            Console.WriteLine(MinMoves(new int[] { 3, 4, 6, 6, 3 }));
            Console.WriteLine(MinMoves(new int[] { 5, 6, 8, 8, 5 }));

        }

        public static String Interview(int[] array, int totalTime)
        {
            bool flag = true;

            for (int i = 0; i < array.Length; i++)
            {
                if (i == 0 || i == 1)
                {
                    if (array[i] > 5)
                        flag = false;
                }
                if (i == 2 || i == 3)
                {
                    if (array[i] > 10)
                        flag = false;
                }
                if (i == 4 || i == 5)
                {
                    if (array[i] > 15)
                        flag = false;
                }
                if (i == 6 || i == 7)
                {
                    if (array[i] > 20)
                        flag = false;
                }
            }

            if (array.Length != 8 ||
                totalTime > 120)
            {
                flag = false;
            }

            if (flag)
                return "qualified";
            return "disqualified";
        }

        public static int MinMoves(int[] array)
        {
            int count = 0;
            Array.Sort(array);
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                count += array[i] - min;
            }
            return count;
        }
    }
}
