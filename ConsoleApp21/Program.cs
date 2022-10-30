using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                var input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToList();
                var n = input[0];
                var even = Enumerable.Range(1, n).Where(x => x % 2 == 0).ToList();
                var odd = Enumerable.Range(1, n).Where(x => x % 2 != 0).ToList();
                even.Sort();
                even.Reverse();
                odd.Sort();
                odd.Reverse();
                //var res = new List<int>();
                //int ei = 0;
                //int oi = 0;
                if (n == 1)
                    Console.WriteLine(n);
                else
                {
                    //for (int i = 1; i <= n; i++)
                    //{
                    //    if (i % 2 != 0)
                    //    {
                    //        res.Add(even[ei]);
                    //        ei++;
                    //    }
                    //    else
                    //    {
                    //        res.Add(odd[oi]);
                    //        oi++;
                    //    }
                    var res = "";
                    if (n % 2 != 0)
                    {
                        var r = even;
                        foreach (var x in r)
                        {
                            res = res + x + " ";
                        }
                        r = odd;
                        foreach (var x in r)
                        {
                            res = res + x + " ";
                        }
                    }
                    else
                    {
                        foreach (var x in odd)
                        {
                            res = res + x + " ";
                        }
                        //r = odd;
                        foreach (var x in even)
                        {
                            res = res + x + " ";
                        }
                    }
                    res = res.Trim();
                    Console.WriteLine(res);
                    //Console.WriteLine();

                }
                //foreach (var x in res)
                //{
                //    Console.Write(x + " ");
                //}
                Console.WriteLine();
                //Console.ReadLine();
            }
        }
        // Console.ReadLine();
    }
}

