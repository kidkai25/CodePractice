using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrefixSum3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> A = new List<int> { 5, -2, 3, 1,2};
            int B = 3;
            int[] preFix = new int[A.Count];

            int n = A.Count;
            int[] suff = new int[n + 1];
            suff[n] = 0;
            suff[n - 1] = A[n - 1];
            for (int i = n - 2; i >= 0; i--)
            {
                suff[i] = A[i] + suff[i + 1];
            }
            int pref_sum = 0;
            int ans = suff[n - B];
            for (int i = 0; i < B; i++)
            {
                pref_sum = pref_sum + A[i];
                int suff_sum = suff[n - B + (i + 1)];
                ans = Math.Max(ans, pref_sum + suff_sum);
            }
            //return ans;
            

            Console.WriteLine(ans);
            Console.ReadLine();
        }

        static void X ()
        {
            //int result = 0;
            //int n = A.Count;
            ////calculating prefix sum
            //for (int i = 0; i < B; i++)
            //    result += A[i];
            //int sum = result;

            ////result = preFix[n - 1];

            //for (int i = 0; i < B; i++)
            //{
            //    var x = B - 1 - i;
            //    var y = n - 1 - i;
            //    sum -= A[x];
            //    sum += A[y];

            //    result = Math.Max(result, sum);
            //}
        }
    }
}
