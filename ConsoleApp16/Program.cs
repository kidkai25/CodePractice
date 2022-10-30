using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> A = new List<int>{ 1, 2, 3, 4, 5 };
            List<int> B = new List<int> { 2, 3 };
            var x = solve(A, B);
        }

        public static List<List<int>> solve(List<int> A, List<int> B)
        {
            List<List<int>> C = new List<List<int>>();

            for(int i = 0; i < B.Count; i++)
            {
                List<int> result = new List<int>(A);
                //result = A;
                //C.Add(new List<int>());

                var cutOff = B[i] % result.Count;
               //cutOff = 3;
                //Reverse
                var rr = result.Count;
                // 1 2 3 4 5
                //var x = 2, 3;

                RotateArray(result, 0, cutOff - 1); //2 1 
                RotateArray(result, rr - (rr - cutOff), rr - 1);// 5 4 3
                RotateArray(result, 0, rr - 1);// 2 1 5 4 3
                                                // 3 4 5 1 2

                string r = string.Join(" ", result);
                Console.WriteLine(r);
                //Console.ReadKey();
                C.Add(result);
            }

            return C;
        }

        public static void RotateArray(List<int> A, int begin, int end)
        {
            int i = begin;
            int j = end;

            while(i < j)
            {
                int temp = 0;
                //swap
                temp = A[i];
                A[i] = A[j];
                A[j] = temp;

                i++;
                j--;
            }
        }
    }
}
