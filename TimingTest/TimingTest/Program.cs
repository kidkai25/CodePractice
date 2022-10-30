using System;
using System.Diagnostics;
using System.Linq;

namespace TimingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 2, 5, 5, 5, 6, 7, 8, 12, 11, 89, 22 };

            Console.WriteLine(FindMax(x));

            Console.Read();
        }

        static int FindMax(params int[] nums)
        {
            return nums.Max();
        }
    }
}
