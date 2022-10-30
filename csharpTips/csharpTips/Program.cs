using System;
using System.Globalization;
using System.Linq;

namespace csharpTips
{
    class Program
    {
        static void Main(string[] args)
        {

            var x = int.Parse("(50)", NumberStyles.AllowParentheses);

            Console.WriteLine(x);
        }
    }
}
