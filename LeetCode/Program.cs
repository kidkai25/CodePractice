using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCase = int.Parse(Console.ReadLine());
            while (testCase-- > 0)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int n = input[0];
                int m = input[1];
                int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
                string s = string.Concat(Enumerable.Repeat("B", m));
                //sort it
                Array.Sort(arr);
                string result = s;
                for (int i = 0; i < arr.Length; i++)
                {
                    char[] r1 = result.ToCharArray();
                    //depends where to go

                    var pos = (m + 1) - arr[i];
                    //pos can be 5 or 1
                    //or pos can be 1 or 5
                    var a = m + 1 - pos; // 1
                    var b = pos; // 5
                    //choose minimum
                     pos = Math.Min(a, b);

                    if (result[pos - 1] != 'A')
                        r1[pos - 1] = 'A';
                    else
                        r1[m - pos] = 'A';                    

                    string r = new string(r1);
                    result = string.Compare(r, result) < 0 ? r : result;
                    result = r;
                }
                Console.WriteLine(result);
            }
        }
    }
}
