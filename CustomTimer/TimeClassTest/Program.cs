using CustomTimer;
using System;

namespace TimeClassTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[100000];
            BuildArray(nums);
            Timing ob = new Timing();
            ob.StartTime();
            DisplayNums(nums);
            ob.StopTime();
            Console.WriteLine("time (.NET): " + ob.Result().TotalSeconds);
        }

        static void BuildArray(int[] arr)
        {
            for (int i = 0; i < 100000; i++)
            {
                arr[i] = i;
            }
        }

        static void DisplayNums(int[] arr)
        {
            for (int i = 0; i < arr.GetUpperBound(0); i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
        }
    }
}
