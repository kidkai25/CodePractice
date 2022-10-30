using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    class Program
    {
        static void Main(string[] args)
        {
                
        }

        public static int solve(List<int> A)
        {
            A.Sort();
            long c = 1, res = 0, mod = 1000000007;
            int n = A.Count();
            for(int i = 0; i < n; ++i,c = c* 2 % mod)
            {
                res = (res + A[i] * c - A[n - i - 1] * c) % mod;
            }
            return (int)((res + mod) % mod);
        }
    }
}
