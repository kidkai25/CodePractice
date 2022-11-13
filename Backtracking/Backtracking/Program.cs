using System;
using System.Collections.Generic;

namespace Backtracking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var x = permute(new List<int>(new int[3]));
            var x = permute(new List<int>{ 1,2,3});
            var y = x;
            Console.WriteLine("Hello World!");
        }
        public static List<List<int>> permute(List<int> A)
        {
            List<List<int>> res = new List<List<int>>();

            int N = A.Count;
            int i = 0;
            //P(res, i, A, N);
            P2(res, i, A, N);
            return res;
        }

        public static void P(List<List<int>> res, int i, List<int> A, int N)
        {
            if (i >= N)
            {
                res.Add(new List<int>(A));
                return;
            }

            //A[i] = 1;
            //P(res, i + 1, A, 3);
            //A[i] = 2;
            //P(res, i + 1, A, 3);

            for (int j = 0; j < N; j++)
            {
                A[i] = A[j];
                P(res, i + 1, A, N);
            }
        }

        public static void P2(List<List<int>> res, int i, List<int> A, int N)
        {
            if (i >= N)
            {
                res.Add(new List<int>(A));
                return;
            }

            for (int j = i; j < N; j++)
            {
                Swap(i, j, A);
                P2(res, i + 1, A, N);
                Swap(i, j, A);
            }
        }

        public static void Swap(int i, int j, List<int> A)
        {
            var temp = A[i];
            A[i] = A[j];
            A[j] = temp;
        }

    }
}
