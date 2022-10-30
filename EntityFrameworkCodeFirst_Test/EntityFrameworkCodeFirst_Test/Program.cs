using EntityFrameworkCodeFirst_Test.Model;
using System;

namespace EntityFrameworkCodeFirst_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserting Destination-----");
            InsertDestination();
            Console.WriteLine("Destination Added :)");
        }

        static void InsertDestination()
        {
            var destination = new Destination
            {
                Country = "India",
                Description = "A country in asia",
                Name = "Delhi"
            };

            using(var context = new BreakAwayContext())
            {
                context.Destinations.Add(destination);
                context.SaveChanges();
            }
        }
    }
}
