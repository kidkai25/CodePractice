using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = int.Parse(Console.ReadLine());

            //intializing array
            int[] arr = new int[x + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = -1;
            }
            Console.WriteLine(Fib(x,arr));
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
    }
}
