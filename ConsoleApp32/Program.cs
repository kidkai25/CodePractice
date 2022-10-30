using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                var input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToList();

                int n = input[0];
                int m = input[1];
                int s1 = input[2];
                int s2 = input[3];
                int d = input[4];

                var x = new HashSet<int>(n * m);


                x.Add(s1);
                x.Add(s2);

                for (int i = s1; i < (s1 + d); i++)
                    x.Add(i);

                for (int i = s1; i < (s2 + d); i++)
                    x.Add(i);

                
            }
        }
    }
}
