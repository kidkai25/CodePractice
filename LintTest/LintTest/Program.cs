using LintTest.DataSources;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace LintTest
{

    public class AnagramEqualityComparer : IEqualityComparer<string>
    {
        public bool Equals(string x, string y) => GetCanonicalString(x) == GetCanonicalString(y);
        
        public int GetHashCode(string obj) => GetCanonicalString(obj).GetHashCode();
        
        private string GetCanonicalString(string word)
        {
            char[] wordChars = word.ToCharArray();
            Array.Sort<Char>(wordChars);
            return new string(wordChars);
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            //CrossJoin();
            //GroupJoin();
            GroupJoinLinqExpression();
        }


        static void CrossJoin()
        {
            string[] categories =
            {
                "Beverages",
                "Condiments",
                "Vegetables",
                "Dairy Products",
                "Seafood"
            };

            List<Product> products = Products.ProductList;

            var q = from c in categories
                    join p in products on c equals p.Category
                    select (Category: c, p.ProductName);

            foreach(var v in q)
            {
                Console.WriteLine(v.ProductName + ":" + v.Category);
            }
 
        }

        static void GroupJoin()
        {
            string[] categories = { "Beverages", "Condiments", "Vegetables", "Dairy Products", "Seafood" };

            List<Product> products = Products.ProductList;

            var q = from c in categories
                    join p in products on c equals p.Category into ps
                    select (Category: c, Products: ps);

            foreach(var v in q)
            {
                Console.WriteLine(v.Category + ":");
                foreach(var p in v.Products)
                {
                    Console.WriteLine("  " + p.ProductName);
                }
            }

        }


        static void GroupJoinLinqExpression()
        {
            string[] categories = { "Beverages", "Condiments", "Vegetables", "Dairy Products", "Seafood" };

            List<Product> products = Products.ProductList;

            var result = categories.GroupJoin(products, x => x, y => y.Category,
                (x, y) => new {

                    Category = x, 
                    Products = y
                }        
        );

            foreach(var v in result)
            {
                Console.WriteLine(v.Category + ":");
                    
                foreach(var p in v.Products)
                {
                    Console.WriteLine("   " + p.ProductName);
                }
            }

        }


        static void GroupByUsingProperty()
        {
            string[] words = { "blueberry", "chimpanzee", "abacus", "banana", "apple", "cheese" };

            //var wordGroups = from w in words
            //                 group w by w[0] into g
            //                 select (FirstLetter: g.Key, Words: g);

            var wordGroups = words.GroupBy(x => x[0])
                                  .Select(x => new {FirstLetter = x.Key, Words = x});

            foreach (var g in wordGroups)
            {
                Console.WriteLine("Words that start with the letter '{0}':", g.FirstLetter);
                foreach (var w in g.Words)
                {
                    Console.WriteLine(w);
                }
            }
        }
        static void Bucket()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 0 };
            //var numberGroups = from n in numbers
            //                   group n by n % 5 into g
            //                   select (Remainder: g.Key, Numbers: g);

            var numberGroups = numbers.GroupBy(x => x % 5)
                                      .Select(x => new { Remainder = x.Key, Numbers = x });


            foreach (var g in numberGroups)
            {
                Console.WriteLine($"Numb" +
                    $"ers with a remainder of {g.Remainder} when divided by 5:");
                foreach (var n in g.Numbers)
                {
                    Console.WriteLine(n);
                }
            }
        }
    }
}
