using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = pow(-1, 1, 20);
            x = pow(2, 1, 20);
            Console.WriteLine();
            Console.ReadLine();
        }

        public static int pow(int A, int B, int C)
        {
            long result = pow2(A, B / 2, C);
            if (A < 0)
            {
                return (int)(result % C) + C;
                //Console.WriteLine(result);
                return 0;
            }
            else
                return (int)(result % C);
        }
        public static long pow2(long A, long B, long C)
        {
            if (B == 0)
                return 1;

            long pow = pow2(A, B / 2, C);

            if ((B & 1) != 0)
                return pow * pow;
            else
                return A * pow * pow;

        }
    }
}
