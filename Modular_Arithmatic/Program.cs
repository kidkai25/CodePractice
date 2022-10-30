using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modular_Arithmatic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(lcm(2,3));
            Console.WriteLine(lcm(9,6));
            Console.WriteLine(lcm(2,6));
            Console.ReadLine();
        }
        static int lcm(int A, int B)
        {
            //Find Larger and Smaller
            int l = Math.Max(A, B);
            int s = Math.Min(A, B);

            if (l % s == 0)
                return l;
            bool notFound = true;
            int count = 1;
            while(notFound)
            {
                var num = count * l;
                if ((num) % s == 0)
                    return num;
                count++;
            }

            return 0;
        }
    }
}
