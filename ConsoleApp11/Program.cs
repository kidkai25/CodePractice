using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 4.00000;
            double y= Math.Round(x, 2);
            decimal z = Math.Round((decimal)x, 2);

            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.Read();

        }
    }
}
