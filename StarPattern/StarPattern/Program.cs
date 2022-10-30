using System;
using System.CodeDom.Compiler;

namespace StarPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;

            for (int i = 0; i < n; i++)
            {
                //Add possible left spaces
                var rightTriangleLineSize = (2 * i) + 1;

                var spaceLeft = (2 * n - 1) - rightTriangleLineSize;

                PrintSpace(spaceLeft / 2);

                //Depending on i 
                CreateRightTriangle(i);

                //Add possible right spaces
                PrintSpace(spaceLeft / 2);
                
                Console.WriteLine();
            }
            
        }

        static void CreateRightTriangle(int n)
        {
            for (int k = 0; k <= 2 * n; k++)
            {
                if (k % 2 == 0)
                    Console.Write("*");
                else Console.Write(" ");
            }
        }
        static void PrintSpace(int n)
        {
            for (int k = 0; k < n; k++)
            {
                Console.Write(" ");
            }
        }
    }
}
