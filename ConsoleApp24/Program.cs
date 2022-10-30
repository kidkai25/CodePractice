using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            string A = "1010110111001101101000";
            string B = "1000011011000000111100110";
            int max = Math.Max(A.Length, B.Length);
            string C = A.PadLeft(max, '0');
            string D = B.PadLeft(max, '0');
            int carry = 0;
            int ans = 0;
            for (int i = max - 1; i >= 0; i--)
            {
                int a = C[i] - '0';
                int b = D[i] - '0';
                if ((a + b + carry) >= 2)
                {
                    carry = 1;
                }
                else
                    carry = 0;

                //set bit
                ans = ans | 1 << (max - i - 1);
            }
            //myString.Substring(Convert.Length-3)

            string binary = Convert.ToString(ans, 2);
        }
    }
}
