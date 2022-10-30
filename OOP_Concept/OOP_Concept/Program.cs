using System;
using System.Security.Cryptography.X509Certificates;

namespace OOP_Concept
{
    class Parent
    {

        public virtual void PrintHello()
        {
            Console.WriteLine("Parent Printed Hello");
        }
    }
    class Child : Parent
    {
        public override void PrintHello()
        {
            Console.WriteLine("Child Printed Hello");
        }
        public void PrintHello2()
        {
            Console.WriteLine("Child Printed Hello");
        }
    }
    class Program
    { 
        static void Main(string[] args)
        {
            Parent p = new Child();
            p.PrintHello();
            Child c = new Child();
            c.PrintHello();
            Console.ReadLine();
        }
    }
}
