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

            //var x = solve(new List<int> { 1, 2, 3, 4, 5 });
            //solve(new List<int> { 10, 2, 13, 4 });
            //var x = new List<int> { 24, -68, -29, -9, 84 };
            //var b = 4;
            //Console.WriteLine(Solve2(x, b));
            //x = new List<int> { 57, 3, -14, -87, 42, 38, 31, -7, -28, -61 };
            //b = 10;
            var x = new List<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine(Solve3(x));
            x = new List<int> { 5, 17, 100, 11 };
            Console.WriteLine(Solve3(x));

        }

        public static int Solve2(List<int> A, int B)
        {
            //Create a min PQ
            PriorityQueue<int> pq = new PriorityQueue<int>(true);
            List<int> result = new List<int>();

            for (int i = 0; i < A.Count; i++)            
                pq.Enqueue(A[i], A[i]);
            
            //main loop :)

            for(int i = 0; i < B; i++)
            {
                var x = pq.Dequeue() * -1;
                pq.Enqueue(x, x);
            }

            for(int i = 0; i < A.Count; i++)
            {
                result.Add(pq.Dequeue());
            }
            return result.Sum();
        }

        static int Solve3(List<int> A)
        {
            int cost = 0;
            PriorityQueue<int> pq = new PriorityQueue<int>(true);
            for (int i = 0; i < A.Count; i++)
            {
                pq.Enqueue(A[i], A[i]); 
            }
            for(int i = 0; i < A.Count - 1; i++)
            {
                int x = pq.Dequeue();
                int y = pq.Dequeue();
                cost += x + y;
                pq.Enqueue((x + y), (x + y));
            }
            return cost;
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
