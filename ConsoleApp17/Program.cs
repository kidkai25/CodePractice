using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> A = new List<int> { 2, 9, 5};
            List<int> A = new List<int> { 5,3,-10,0,4 };
            int sum = 0;
            int length = A.Count;
            int ans = 0;
            for (int i = 0; i < length; i++)
            {
                for (int j = i; j < length; j++)
                {
                    sum += A[j];
                    ans = Math.Max(sum, ans);

                }
            }
             sum = 0;
            for (int i = 0; i < A.Count; i++)
            {
                for (int j = i; j < A.Count; j++)
                {
                    for (int k = i; k <= j; k++)
                    {
                        sum += A[j];
                    }
                }

            }
            Console.WriteLine(ans);
            Console.WriteLine(sum);
            Console.ReadKey();
            //int largestSum = Int32.MinValue;
            //for (int i = 0; i < A.Count; i++)
            //{
            //    int sum = 0;
            //    for (int j = i; j < A.Count; j++)
            //    {
            //        sum += A[j];
            //        if (sum > largestSum)
            //            largestSum = sum;
            //    }

            //}
            //Console.WriteLine(largestSum);
            Console.ReadLine();
            //for (int i = 0; i < A.Count; i++)
            //{
            //    for(int j = i; j < A.Count; j++)
            //    {
            //        for (int k = i; k < j; k++)
            //        {
            //            Console.WriteLine(A[k]);
            //        }
            //        Console.WriteLine("----");
            //    }
            //    Console.WriteLine("xxxxx");
            //}
            //var x = Int32.MinValue;
            //Console.ReadLine();
        }
    }
}
