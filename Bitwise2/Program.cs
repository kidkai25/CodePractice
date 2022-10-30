using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitwise2
{
    class Program
    {
        static void Main(string[] args)
        {
            //string A = "001";
            //string B = "010";
            //var a = Convert.ToInt64(A, 2);
            //var b = Convert.ToInt64(B, 2);

            //var x = "101111000100100111001010101001110100001100001010110011100100011010100000";
            ////var y = Convert.ToUInt64(x,2);
            //var z = 450676354;
            //Console.WriteLine(Convert.ToString(z, 2));
            //int x = 2;
            //Console.WriteLine(Convert.ToString(x,2));
            //int y = x << 1;
            //Console.WriteLine(Convert.ToString(y,2));
            //int z = x << 2;
            //Console.WriteLine(Convert.ToString(z,2));
            //Console.WriteLine(A);
            //int A = 5;
            //int result = 0;
            //while (A > 0)
            //{
            //    // //numer
            //    // int t = 0;
            //    // t = A % 2;
            //    // if(A%2  == 1)
            //    // result++;
            //    // A = A /2; 
            //    //shifting
            //    var z = A & 1;
            //    var y = z;
            //    if ((A & 1) == A) //is odd                            
            //        result++;
            //    A = A >> 1; //shifting to happen each time :x
            //                //divide by 2
            //}
            //Console.WriteLine(result); 
            List<int> l = new List<int>{ 1, 0};
            var x = solve(0, l);
            Console.WriteLine(x);
            Console.ReadLine();
        }
        public static long solve(int A, List<int> B)
        {
            long count = 0;
            bool found = false;
            for (int i = 0; i < B.Count; i++)
            {
                for (int j = i; j < B.Count; j++)
                {
                    for (int k = i; k < j; k++) //getting subarray
                    {
                        if ((B[k] == 1) && !found)
                        {
                            count++;
                            found = true;
                        }
                    }
                    found = false; //getting ready for next subarray
                }
            }
            return count;
        }
    }
}
