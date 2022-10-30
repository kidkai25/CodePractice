using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<List<int>>();
            List<int> l = new List<int>() { 1,2,10};
            List<int> l2 = new List<int>() { 2,3,20};
            List<int> l3 = new List<int>() { 2, 5, 25 };
            list.Add(l);
            list.Add(l2);
            list.Add(l3);
            var x = solve(5, list);
            Console.ReadLine();
        }

        public static List<int> solve(int A, List<List<int>> B)
        {

            List<int> res = new List<int>(new int[A]);

            //iterate over B
            for (int i = 0; i < B.Count; i++)
            {
                //for (int j = 0; j < 3; j++)
                //{
                    //L
                    int l = B[i][0];
                    int r = B[i][1];
                    int p = B[i][2];


                    //mark
                    //result.Insert(l - 1, p)
                    res[l - 1] += p;
                    if (r != A)
                        res[r] += -(p);
                    else
                        res[r - 1] += (p);
                //}
            }

            //marking done :D
            //Console.Write(res[0] + " xx" + res[1] + "xx " + res[2] + "xx " + res[3]);
            for (int i = 1; i < res.Count; i++)
            {
                //var x = res[i - 1] < 0
                if(i != res.Count - 1)                    
                res[i] = res[i] + (res[i - 1] < 0 ? 0 : res[i - 1]);
            }
            return res;
        }
    }
}
