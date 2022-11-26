using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var x = int.Parse(Console.ReadLine());

            //intializing array
            //int[] arr = new int[x + 1];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = -1;
            //}
            //Console.WriteLine(Fib(x,arr));
            List<int> A =new List<int> { 60, 100, 120 };
            List<int> B = new List<int> { 10, 20, 30 };
            int C = 50;
            solve(A, B, C);
            Console.ReadLine();
        }
        static int Fib(int n, int[] arr)

        {
            if (n == 1)
                return 1;
            if (n <= 0)
                return 0;
            if (arr[n] != -1)   
                return arr[n];

            int ans = Fib(n - 1, arr) + Fib(n - 2, arr);
            arr[n] = ans;
            return ans;
        }

        public static void solve(List<int> A, List<int> B, int C)
        {
            //create a dp matrix
            int[,] knapSack = new int[A.Count + 1, C + 1];

            //default values
            for(int i = 1; i <= A.Count; i++)
            {
                for(int j = 1; j <= C; j++)
                {
                    knapSack[i,j] = -1;
                }
            }

            var result = MaxValue(A.Count,C,knapSack, A,B);
            Console.WriteLine(result);

        }
        public static int MaxValue(int n, int w,int[,] knapsack, List<int> value, List<int> weight)
        {
            if(n == 0 || w == 0)
            {
                return 0;
            }

            //var x = int index = myList.FindIndex(a => a.Prop == oProp);
            if (knapsack[n, w] != -1)
                return knapsack[n, w];
            //pick element if possible
            if (weight[n - 1] <= w)
            {
                knapsack[n, w] = Math.Max(value[n - 1] + MaxValue(n - 1, w - weight[n - 1], knapsack, value, weight),
                                    MaxValue(n - 1, w,  knapsack,value,weight));
                                        
            }
            else
            {
                knapsack[n, w] = MaxValue(n - 1, w,knapsack,value,weight);
            }

            return knapsack[n, w];
        }
    }
}
