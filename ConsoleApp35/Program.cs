using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> A = new List<int> { 1, 4, 10, 2 };
            //List<int> A = new List<int> { 10,3,8,15,6,12,2,18,7,1 };
            //List<int> A = new List<int> { 1,2,3};
            //List<int> A = new List<int> { 3 17 18 18 20 21 21 21 24 31 35 35 38 39 39 42 47 47 49 55 56 56 61 65 67 70 70 76 78 79 81 86 94 94 98 };
            //List<int> A = new List<int> { 17, 18, 18, 20, 21,21,21};
            //int n = A.Count;
            //QuickSort(A, 0, n - 1);
            //var x = A;
            List<int> a = new List<int> { 1, 3 };
            List<int> b = new List<int> { -2, -2 };
            List<List<int>> A = new List<List<int>>();
            A.Add(a);
            A.Add(b);
            solve(A, 1);
            Console.WriteLine("Help");
            Console.ReadLine();

        }
        public static List<List<int>> solve(List<List<int>> A, int B)
        {
            for(int i = 1; i < A.Count; i++)
            {
                double value = Math.Pow(A[i][0], 2) + Math.Pow(A[i][1], 2);

                var key = A[i];
                var flag = 0;
                for (int j = i - 1; j >= 0 && flag != 1;)
                {
                    double value2 = Math.Pow(A[j][0], 2) + Math.Pow(A[j][1], 2);
                    if (value < value2)
                    {
                        A[j + 1] = A[j];
                        j--;
                        A[j + 1] = key;
                    }
                    else flag = 1;
                }

            }
            return A.Take(B).ToList();
        }
        public static int Rearrange(List<int> A, int l, int r)
        {
            int p1 = l + 1;
            int p2 = r;
            int temp = 0;
            while (p1 <= p2)
            {
                if (A[p1] <= A[l])
                {
                    p1++;
                }
                else if (A[p2] > A[l])
                {
                    p2--;
                }
                else
                {
                    temp = A[p1];
                    A[p1] = A[p2];
                    A[p2] = temp;
                    p1++;
                    p2--;
                }
            }
            if (l <= r)
            {
                //final swap
                temp = A[l];
                A[l] = A[p2];
                A[p2] = temp;
            }

            return p2;
        }

        public static void QuickSort(List<int> A, int l, int r)
        {
            if (l == r)
                return;
            if (l < r)
            {
                int idx = Rearrange(A, l, r);
                //if (idx > 1)
                    QuickSort(A, l, idx - 1);
              //  if (idx + 1 < r)
                    QuickSort(A, idx + 1, r);
            }
        }


    }
}
