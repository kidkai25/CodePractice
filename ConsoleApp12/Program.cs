using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            int tc = int.Parse(Console.ReadLine());

            while (tc-- > 0)
            {
                int[] input = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

                int G = input[0];
                int P = input[1];
                int X1 = input[2];
                int X2 = input[3];
                int X3 = input[4];
                int X4 = input[5];
                int X5 = input[6];
                int X6 = input[7];
                int X7 = input[8];
                int X8 = input[9];
                int X9 = input[10];
                int X10 = input[11];

                List<int> groups = new List<int>();

                groups.Add(X1); //0
                groups.Add(X2); //1
                groups.Add(X3); //2
                groups.Add(X4); //3
                groups.Add(X5); //4
                groups.Add(X6); //5
                groups.Add(X7); //6
                groups.Add(X8); //7
                groups.Add(X9); //8
                groups.Add(X10); //9

                int preChefSum = 0;
                for(int i = G; i < groups.Count; i++)
                {
                    preChefSum += groups[i];
                }
                var min =(int)Math.Ceiling((double)(preChefSum + 1) /P);
                var max = (int)Math.Ceiling((double)((preChefSum) + groups[G - 1])/P);


                Console.WriteLine(min + " " + max);
                //Console.ReadKey();
            }
        }
    }
}
