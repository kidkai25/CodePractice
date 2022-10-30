using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    class Program
    {
        static void Main(string[] args)
        {
            //var l = new List<int>() { 1, 1, 3 };
            //Console.WriteLine(solve(l));
            //var r = new List<int>() { 2, 4, 5 };
            //Console.WriteLine(solve(r));
           // var r = new List<int> { 51, 6, 10, 8, 22, 61, 56, 48, 88, 85, 21, 98, 81, 76, 71, 68, 18, 6, 14, 23, 72, 18, 56, 30, 97, 100, 81, 5, 99, 2, 85, 67, 46, 32, 66, 51, 76, 53, 36, 31, 81, 56, 26, 75, 69, 54, 54, 54, 83, 41, 86, 48, 7, 32, 85, 23, 47, 23, 18, 45, 79, 95, 73, 15, 55, 16, 66, 73, 13, 85, 14, 80, 39, 92, 66, 20, 22, 25, 34, 14, 51, 14, 17, 10, 100, 35, 9, 83, 31, 60, 24, 37, 69, 62 };
            var r = new List<int> { 3, 2, 1, 2, 1, 7 };
            var x = solve(r);
            var y = x;
            Console.ReadLine();
        }

        public static int solve(List<int> A)
        {
            int res = 0;
            int n = A.Count;
            A.Sort();
            int need = 0;           
            for (int i = 0; i < n; i++)
            {
                res += Math.Max(need - A[i], 0);
                need = Math.Max(A[i], need) + 1;
                
            }

            return res;
        }

        //public static  int solve(List<int> A)
        //{
        //    int count = 0;
        //    int n = A.Count;
        //    A.Sort();
        //    int dup = 0;
        //    for(int i = 0; i < n - 1; i++)
        //    {

        //        if(A[i] == A[i + 1])
        //        {
        //            //A[i + 1] += 1;
        //            //count++;
        //            dup++;
        //            A[i + 1] += 1;
        //        }
        //        else
        //        {
        //            if (dup > 0)
        //            {
        //                count += (dup * (dup + 1)) / 2;
        //                A[i + 1] = A[i] - A[i+1] + 1;
        //                dup = 0;
        //            }
        //        }
        //    }

        //    return (count * (count + 1))/2;
        //}

    }
}
