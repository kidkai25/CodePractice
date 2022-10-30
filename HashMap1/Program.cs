using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashMap1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> A = new List<int> { 1, 2, 2, 1 };
            List<int> B = new List<int> { 2, 3, 1, 2 };

            //var x = solve(A, B);
            List<int> A2 = new List<int> { 10, 5, 3, 4, 3, 5, 6 };
            var x = solve2(A2);
            Console.WriteLine();
            Console.ReadLine();
        }
        public static List<int> solve(List<int> A, List<int> B)
        {
            //Create 2 hashmaps
            var h = new Dictionary<int, int>();
            var h2 = new Dictionary<int, int>();
            List<int> result = new List<int>();

            foreach (var a in A)
            {
                if (!h.ContainsKey(a))
                {
                    h.Add(a, 0);
                }
                h[a]++;
            }
            foreach (var b in B)
            {
                if (!h2.ContainsKey(b))
                {
                    h2.Add(b, 0);
                }
                h2[b]++;
            }

            int count = 0;
            //final iterations
            foreach (var x in h)
            {
                if (h2.ContainsKey(x.Key))
                {
                    count = Math.Min(h[x.Key], h2[x.Key]);
                }
                while (count-- > 0)
                    result.Add(x.Key);
            }

            return result;
        }

        public static int solve2(List<int> A)
        {
            var h = new Dictionary<int, int>();

            foreach (var a in A)
            {
                if (!h.ContainsKey(a))
                {
                    h.Add(a, 0);
                }
                h[a]++;

            }
            foreach (var x in h.Keys)
            {
                if (h[x] == 2)
                    return x;
            }
            return -1;
        }

    }
}
