using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp40
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 2; //painter;
            int B = 5;//time
            A = 10;
            B = 1;
            A = 3;
            B = 10;
            
            List<int> C = new List<int> { 1, 10 };
            C = new List<int> { 1, 8, 11, 3 };
            C = new List<int> { 185, 186, 938, 558, 655, 461, 441, 234, 902, 681 };
            C = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var x = paint(A, B, C);
            Console.WriteLine(x);
            Console.ReadLine();
        }
        static int paint(int A, int B, List<int> C)
        {
            //A Painters;
            //B units of time
            //C array of boards with L length

            var D = C.Select(x => (long)(x * B)).ToList(); //nice data now :)

            //minimum time that will be max of the List;
            long maxD = D.Max();
            long sum = D.Sum();

            //Binary Search
            long l = maxD;
            long r = sum;
            long ans = 0;

            while(l <= r)
            {
                long mid = l + ((r - l) / 2);
                if(Check(D,A,mid))
                {
                    ans = mid;
                    r = mid - 1;
                }
                else
                {
                    
                    l = mid + 1;
                }
            }
            return (int)(ans % 10000003);
        }
        static bool Check(List<long> arr, long N, long time)
        {
            //begining with Worker 1
            long w = 1; //not taking any chances
            long currentWork = 0;

            for(int i = 0; i < N; i++)
            {
                //Can the painter paint the current timeTaken to the current worker
                if(currentWork + arr[i] <= time)
                {
                    currentWork += arr[i];
                }
                else
                {
                    w++;
                    currentWork = arr[i];
                }
                if (w > N)
                    return false;
                //if (arr.Count - 1 == i)
                //    break;
            }
            return true;
        }
    }
}
