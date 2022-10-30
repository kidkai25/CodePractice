using System;
using System.Collections.Generic;

namespace ChapterOneProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CreateNewPatient();
            Console.WriteLine("Bye World");
        }

        static void CreateNewPatient()
        {
            var dog = new AnimalType { TypeName = "Dog" };
            var patient = new Patient
            {
                Name = "Sampson",
                BirthDate = new DateTime(2008, 1, 28),
                AnimalType = dog,
                Visits = new List<Visit>
                {
                    new Visit
                    {
                        Date = new DateTime(2011, 9, 1)
                    }
                }
            };

            using(var context = new VetContext())
            {
                context.Patients.Add(patient);
                context.SaveChanges();
            }
        }
    }
}
