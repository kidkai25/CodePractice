using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeforces
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] a = new string[5];
            int count = 0;

            for (int i = 0; i < 5; i++)
            {
                a[i] = Console.ReadLine().Replace(" ", "");
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (a[i][j] == '1')
                        Console.WriteLine(Math.Abs(i - 2) + Math.Abs(j - 2));
                }
            }
            //Console.ReadLine();

        }
    }
}
