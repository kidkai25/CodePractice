using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{
    class Program
    {
        static void Main(string[] args)
        {

            var A = new List<int>(){ 1, 10, 10 };
            var x = solve(A);
            var y = x;
            //var A = new List<int> { 1, 3, 5, 6,7};
            //var B = 2;
            //int l = 0;
            //int r = A.Count - 1;

            //int index = 0;
            //while (l <= r)
            //{
            //    int mid = l + (r - l) / 2;
            //    if (A[mid] == B)
            //        return mid;

            //    else if (B < A[mid])
            //    {
            //        index = mid;
            //        r = mid - 1;
            //    }
            //    else
            //    {
            //        l = mid + 1;
            //        index = mid;
            //    }
            //}
            //return l;
        }

        public static int solve(List<int> A)
        {
            int n = A.Count;
            int l = 0;
            int r = n - 1;
            int mid = 0;
            //int mid =0;
            while (l <= r)
            {
                mid = l + ((r - l) / 2);

                if (mid < r && mid > l && A[mid - 1] < A[mid] && A[mid] > A[mid + 1])
                    return A[mid];
                else if (mid < r && A[mid] < A[mid + 1])
                    l = mid + 1;
                else
                    r = mid - 1;

            }
            return A[l];
        }
    }
}
