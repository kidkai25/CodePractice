using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DescendingOrder(1021));
            Console.ReadLine();
        }

        public static int DescendingOrder(int num)
        {
            int largest = -1;
            int d = -1;
            var result = num;
            if (result < 10)
                return result;
            //return highest number on each call
            while (num != 0)
            {
                if (num % 10 > largest)
                    largest = num % 10;
                num = num / 10;
                d++;
            }
            largest = largest * (int)Math.Pow(10, d);
            Console.WriteLine(largest);
            return largest + DescendingOrder(result/10);
        }
    }
}
