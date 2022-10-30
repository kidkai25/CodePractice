using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int tc = int.Parse(Console.ReadLine());

                while (tc-- > 0)
                {
                    int n = int.Parse(Console.ReadLine());

                    var input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToList();
                    //Console.WriteLine(input);
                    if (input != null && input.Count >= 2)
                    {

                        int diff = input[1] - input[0];
                        bool failed = false;
                        if (diff < 0)
                            failed = true;
                        //Console.WriteLine(2);
                        var first = input.FirstOrDefault();
                        if (first != 0)
                        {
                            while (input.Skip(1).Sum() != 0)
                            {
                                //Console.WriteLine(3);
                                //
                                for (int i = 1; i < input.Count; i++)
                                {

                                    if (input[i] != 0 && input[i] > input[i - 1])
                                    {
                                        input[i] = input[i] - input[i - 1];
                                        break;
                                    }
                                    if (input[i] < input[i - 1])
                                    {
                                        failed = true;
                                        break;
                                    }
                                }

                                if (input.Skip(1).Distinct().Count() == 1)
                                    break;
                                if (failed)
                                    break;
                            }

                            if (failed)
                                Console.WriteLine("NO");
                            else
                                Console.WriteLine("YES");
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
