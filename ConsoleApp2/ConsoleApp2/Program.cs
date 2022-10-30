using System;

namespace ConsoleApp2
{
    class A
    {
        public A()
        {
         
        }
        public A(int a)
        {
            Console.WriteLine("A");
        }
    }

    class B : A
    {
        public B()
        {
            Console.WriteLine("B");
        }
        public B(int a) : base(a)
        {
            Console.WriteLine("B1");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
        }
    }
}
