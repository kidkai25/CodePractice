using System;
using System.Collections;
using System.Collections.Generic;
using System.Security;

namespace ConsoleApp4
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string str = "Hello World";
            string result = ReverseWords(str);
            Console.WriteLine(result);
        }        
        
        static string ReverseWords(string str)
        {
            Stack<string> st = new Stack<string>();

            string resStr = string.Empty;

            foreach(var ch in str)
            {
                if (ch != ' ')
                    resStr += ch;
                else
                {
                    st.Push(resStr);
                    resStr = string.Empty;
                }
            }

            //The last word
            st.Push(resStr);
            resStr = string.Empty;

            while(st.Count != 0)            
                resStr += st.Pop();            

            return resStr;
        }
    }
}
