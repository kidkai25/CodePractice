using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Schema;

namespace ConsoleApp44
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var x = solve(new List<int> { 1, 2, 3, 4, 5 });
            solve(new List<int> { 10, 2, 13, 4 });

        }

            

        static List<int> solve(List<int> A)
        {
            List<int> B = new List<int>();
            SortedList<int,int> C = new SortedList<int,int>(Comparer<int>.Create((x,y) => {

                int res = y.CompareTo(x);
                if (res == 0)
                    return 1;
                else return res;
                }
            ));
           
            for (int i = 0; i < A.Count; i++)
            {
                if (!C.ContainsKey(A[i]))
                C.Add(A[i], A[i]);
                if (i < 2)
                {
                    B.Add(-1);
                  
                }
                else
                {
                    //if (A[i] > C.Last().Value)
                    //{
                        //C.RemoveAt(C.Count - 1);
                        //C.Add(A[i], A[i]);
                    //}
                    B.Add(C.Take(3).Select(x => x.Value).Aggregate((total, next) => total * next));
                }                
            }

            //foreach (var x in B)
            //    Console.WriteLine(x);

            return B;
        }
    }
}
