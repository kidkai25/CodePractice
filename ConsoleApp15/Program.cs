using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        //public static int floorSqrt(int x)
        //{
        //    var sqr = Math.Sqrt(x);
        //    if (sqr % 1 == 0)
        //        return (int)sqr;
        //    else
        //        return 1;

        //}
        public static void test(int n)
        {
            var i = 1;
            var k = 1;
            while (k < n)
            {
                
                k += i;
                ++i;
                Console.WriteLine("Called for n = " + n + " and i = " + i + " and  k =" + k);
            }
            Console.WriteLine("----------------------------" + "i = " + i);
        }

        static void Main(string[] args)
        {

            test(10);
            test(100);
            test(1000);
            test(10000);
            //Console.WriteLine(test(10));
            Console.ReadLine();
        }
    }
}
