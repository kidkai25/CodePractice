using System;
using System.Collections.Generic;


namespace Shunting_Yard
{
    class Program
    {
        private static readonly Dictionary<string, (string symbol, int precedence, bool rightAssociative)> operators
       = new (string symbol, int precedence, bool rightAssociative)[] {
            ("^", 4, true),
            ("*", 3, false),
            ("/", 3, false),
            ("+", 2, false),
            ("-", 2, false)
   }.ToDictionary(op => op.symbol);
        static void Main(string[] args)
        {
        
            
         }

        
    }
}
