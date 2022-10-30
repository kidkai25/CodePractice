using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_bit_manipulation2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> A = new List<int> { 1, 2, 3, 1, 2, 4 };
            //List<int> A = new List<int> { 2308, 1447, 1918, 1391, 2308, 216, 1391, 410, 1021, 537, 1825, 1021, 1729, 669, 216, 1825, 537, 1995, 805, 410, 805, 602, 1918, 1447, 90, 1995, 90, 1540, 1161, 1540, 2160, 1235, 1161, 602, 880, 2160, 1235, 669 };
            var x = Solve(A);
            Console.WriteLine(x);
            Console.ReadLine();
        }

        public static List<int> Solve(List<int> A)
        {
            //xor makes 0
            //1, 2, 3, 1, 2, 4
            // 1 xor 1 + 2 xor 2+ 3 xor 4
            List<int> result = new List<int>();
            int xorResult = 0;
            for (int i = 0; i < A.Count; i++)
            {
                xorResult = xorResult ^ A[i];
            }
            //check which ith bit is one?
            var temp = xorResult;
            int n = 0;
            while (temp > 0)
            {
                if ((temp & 1) == 1)
                    break;
                n++;
                temp = temp >> 1;
            }
            //divide into 2
            List<int> l = new List<int>();
            List<int> l2 = new List<int>();
            for (int i = 0; i < A.Count; i++)
            {
                var x = A[i];
                var nBit = A[i] >> n;
                if ((nBit & 1) == 1)
                    l.Add(A[i]);
                else
                    l2.Add(A[i]);
            }
            l.Sort();
            l2.Sort();
            //final xor
            var r1 = 0;
            var r2 = 0;
            for (int i = 0; i < l.Count; i++)
            {
                r1 = r1 ^ l[i];
            }
            for (int i = 0; i < l2.Count; i++)
            {
                r2 = r2 ^ l2[i];
            }
            result.Add(r1);
            result.Add(r2);
            return result;

        }
    }
}
