using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DMatricesHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> A1 = new List<int> { 1, -2, -3 };
            //List<int> A2 = new List<int> { -4, 5, -6 };
            //List<int> A3 = new List<int> { -7, -8, 9 };
            //List<List<int>> A = new List<List<int>>();
            //A.Add(A1);
            //A.Add(A2);
            //A.Add(A3);
            List<int> A1 = new List<int> { 1, 2, 3, 4 };
            List<int> A2 = new List<int> { 5, 6, 7, 0 };
            List<int> A3 = new List<int> { 9, 2, 0, 4 };
            List<List<int>> A = new List<List<int>>();
            A.Add(A1);
            A.Add(A2);
            A.Add(A3);
            var r = solve2(A);
            var x = 0;
            Console.WriteLine();
        }

        public static int solve(List<List<int>> A)
        {
            //starting index
            int r = 0;
            int n = A.Count;
            int c = n - 1;
            int sum = 0;

            int i = r;
            int j = c;
            while (i < n && j > 0)
            {
                sum += A[i][j];
                i++;
                j--;
            }
            return sum;
        }

        public static List<List<int>> solve2(List<List<int>> A)
        {
            var list = new List<Tuple<int, int>>();
            int r = A.Count;
            int c = A[0].Count;

            //traversing and finding i,j with 0 values
            for(int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if(A[i][j] == 0)
                    {
                        list.Add(new Tuple<int,int>(i,j));
                    }
                }
            }

            //making 0
            for(int k = 0; k < list.Count; k++)
            {
                int i = list[k].Item1;
                int j = list[k].Item2;

                for(int a = 0; a < c; a++)
                {
                    A[i][a] = 0;
                }
                for(int b = 0; b < r; b++)
                {
                    A[b][j] = 0;
                }
            }

            return A;

        }
    }
}
