using LanguageExt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codeforces
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());


            while (k-- > 0)
            {
                bigint[] input = Console.ReadLine().Split().Select(y => bigint.Parse(y)).ToArray();
                int n = (int)input[0];
                bigint x = input[1];
                bigint t = input[2];
                bigint sum = 0;

                List<bigint> timeDurations = new List<bigint>();
                List<bigint> endDuration = new List<bigint>();
                for (bigint i = 0, j = 0; i < n; i++, j += x)
                    //i is participant
                    timeDurations.Add(j);

                for (int i = 0; i < n; i++)
                {
                    var j = timeDurations[i] + t;
                    endDuration.Add(j);
                }

                for (int i = 0; i < n; i++)
                {
                    var endTime = endDuration[i];
                    int count = timeDurations.Skip(i + 1).Where(p => p <= endTime).Count();
                    sum += count;
                }

                Console.WriteLine(sum);
            }
            Console.ReadLine();

        }
    }
}
