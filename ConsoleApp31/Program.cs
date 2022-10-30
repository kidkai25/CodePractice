using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int> { 3, 2, 1 };
            var x = solve(a);
            Console.WriteLine(x);
            a = new List<int> { 1, 2, 3 };
            x = solve(a);
            Console.WriteLine(x);
            Console.ReadLine();
        }

        static int solve(List<int> A)
        {
            var l = 0;
            var r = A.Count - 1;
            var x = InvCount(A, l, r);
            return (int)(x % 1000000007);
        }
        static decimal InvCount(List<int> A, int l, int r)
        {
            if (l == r)
                return 0;
            int mid = (l + r) / 2;
            decimal x = InvCount(A, l, mid);
            decimal y = InvCount(A, mid + 1, r);
            decimal z = Merge(A, l, mid + 1, r); //number of inversions across A and B

            return x + y + z;

        }
        static decimal Merge(List<int> a, int l, int y, int r)
        {
            int p1 = l;
            int p2 = y;
            int p3 = 0;
            List<int> c = new List<int>(r - l + 1);
            decimal count = 0;
            while (p1 < y && p2 <= r)
            {
                if (a[p1] <= a[p2])
                {
                    c.Add(a[p1]);
                    p1++;
                }
                else
                {
                    c.Add(a[p2]);
                    p2++;
                    count += y - p1;
                }
            }
            //pasting remaining elements
            while (p1 < y)
            {
                c.Add(a[p1]);
                p1++;
            }
            while (p2 <= r)
            {
                c.Add(a[p2]);
                p2++;
            }
            /*xxxxxxxxxxxxxxxxxxxxxxxxxxxxxx*/
            //copy back all elements from temp array to the original array
            for (int i = 0; i < r - l + 1; i++)
            {
                a[i + l] = c[i];
                //r--;
            }

            return count;
        }
    }
}
