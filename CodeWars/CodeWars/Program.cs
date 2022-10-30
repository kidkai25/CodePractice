using System;
using System.Linq;
using System.Collections.Generic;

namespace CodeWars
{
    public class Program
    {
        static void Main(string[] args)
        {
            var x = ComputeDepth(42);

            Console.WriteLine(x);
        }
        public static string Balance(string book)
        {
            //First need to clean the lines keeping only letters,digits, dots
            var cleaned = string.Concat(book.Where(c => char.IsDigit(c) || char.IsLetter(c) ||
                                        ". \n".Contains(c))); //dot and space
            //
            var lines = cleaned.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

            //First line contains original price
            var balance = double.Parse(lines[0]);
            var list = new List<string>() {$"Original Balance: {balance:F2}"};

            //Each line after first contains an expense

            var totalExpense = 0.0;
            var expenseCount = 0;

            foreach(var expense in lines.Skip(1))
            {
                //Extracting the expense cost 
                var details = expense.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var cost = double.Parse(detgails[2]);
            }






        }

    }
}
