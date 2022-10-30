using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings2
{
    class Program
    {
        static void Main(string[] args)
        {
            //abbcccbbbcaaccbababcbcabca
            string A = "abbcccbbbcaaccbababcbcabca";
            var x = longestPalindrome(A);
            Console.WriteLine(x);
            Console.ReadLine();
        }
        public static string longestPalindrome(string A)
        {
            string ans = "";
            for (int i = 0; i < A.Length; i++)
            {
                var res = expand(A, i, i);
                ans = ans.Length > res.Length ? ans : res;
                res = expand(A, i, i + 1);
                ans = ans.Length > res.Length ? ans : res;
            }
            return ans;
        }
        public static string expand(string s, int i, int j)
        {
            string ans = string.Empty;
            while (i >= 0 && j < s.Length && s[i] == s[j])
            {
                ans = s.Substring(i, j - i + 1);
                //ans = j - i + 1; //update 
                i--;
                j++;
            }
            return ans;
        }


    }
}
