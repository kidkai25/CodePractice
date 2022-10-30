using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        public int SearchPivot(List<int> A, int B)
        {
            int n = A.Count;
            //define search space
            int l = 0;
            int r = n - 1;

            while(l <= r)
            {
                int mid = l + (r - l) / 2;

                if(mid > l && mid < r && A[mid-1] > A[mid] && A[mid] < A[mid+1])
                {
                    return mid;
                }

            }
        }
    }
}
