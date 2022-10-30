using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Random NumberGen = new Random();

            int rolls = 0;
            int score = 0;

            System.Console.WriteLine("Press any key to roll the dice!");

            Console.ForegroundColor = ConsoleColor.Cyan;

            while (score != 6)
            {
                Console.ReadKey();
                score = NumberGen.Next(1, 7);
                Console.WriteLine("you rolled a " + score + "");
                rolls++;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("It took you " + rolls + " tries to roll a 6");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("");
            Console.WriteLine("Okay, you rolled a 6! Now let's play the lottery!");
            Console.WriteLine("");
            System.Console.WriteLine("Please enter any 6 Numbers between 1 and 49");

            System.Console.WriteLine("Enter your first Number here : ");
            int firstNumber;

            while (!int.TryParse(Console.ReadLine(), out firstNumber))
            {
                Console.WriteLine("That wasn't a Number. Please enter a Number");
            }

            System.Console.WriteLine("Enter your second Number here : ");
            int secondNumber;

            while (!int.TryParse(Console.ReadLine(), out secondNumber))
            {
                Console.WriteLine("That wasn't a Number. Please enter a Number");
            }

            System.Console.WriteLine("Enter your third Number here : ");
            int thirdNumber;

            while (!int.TryParse(Console.ReadLine(), out thirdNumber))
            {
                Console.WriteLine("That wasn't a Number. Please enter a Number");
            }

            System.Console.WriteLine("Enter your fourth Number here : ");
            int fourthNumber;

            while (!int.TryParse(Console.ReadLine(), out fourthNumber))
            {
                Console.WriteLine("That wasn't a Number. Please enter a Number");
            }

            System.Console.WriteLine("Enter your fifth Number here : ");
            int fifthNumber;

            while (!int.TryParse(Console.ReadLine(), out fifthNumber))
            {
                Console.WriteLine("That wasn't a Number. Please enter a Number");
            }

            System.Console.WriteLine("Enter your sixth Number here : ");
            int sixthNumber;

            while (!int.TryParse(Console.ReadLine(), out sixthNumber))
            {
                Console.WriteLine("That wasn't a Number. Please enter a Number");
            }

            System.Console.WriteLine("");
            System.Console.WriteLine("Okay, you have now selected 6 Numbers.");
            Console.Write("Your Numbers are : " + firstNumber + ", " + secondNumber + ", " + thirdNumber + ", " + fourthNumber + ", " + fifthNumber + ", " + sixthNumber);
            Console.ForegroundColor = ConsoleColor.Green;

            int Number1 = NumberGen.Next(1, 50);
            int Number2 = NumberGen.Next(1, 50);
            int Number3 = NumberGen.Next(1, 50);
            int Number4 = NumberGen.Next(1, 50);
            int Number5 = NumberGen.Next(1, 50);
            int Number6 = NumberGen.Next(1, 50);

            System.Console.WriteLine("");

            System.Console.WriteLine(" The lottery Numbers are: ");
            System.Console.WriteLine(Number1);
            System.Console.WriteLine(Number2);
            System.Console.WriteLine(Number3);
            System.Console.WriteLine(Number4);
            System.Console.WriteLine(Number5);
            System.Console.WriteLine(Number6);


            System.Console.WriteLine("");

            if (Number1 == firstNumber || Number1 == secondNumber || Number1 == thirdNumber || Number1 == fourthNumber || Number1 == fifthNumber || Number1 == sixthNumber)
            {
                System.Console.WriteLine("Number 1 (" + firstNumber + ") is correct");
            }
            else
            {
                Console.WriteLine("Your first Number is wrong");
            }

            System.Console.WriteLine("");

            if (Number2 == firstNumber || Number2 == secondNumber || Number2 == thirdNumber || Number2 == fourthNumber || Number2 == fifthNumber || Number2 == sixthNumber)
            {
                System.Console.WriteLine("Number 2 (" + secondNumber + ") is correct");
            }
            else
            {
                Console.WriteLine("Your second Number is wrong");
            }

            System.Console.WriteLine("");

            if (Number3 == firstNumber || Number3 == secondNumber || Number3 == thirdNumber || Number3 == fourthNumber || Number3 == fifthNumber || Number3 == sixthNumber)
            {
                System.Console.WriteLine("Number 3 (" + thirdNumber + ") is correct");
            }
            else
            {
                Console.WriteLine("Your third zahl is wrong");
            }

            System.Console.WriteLine("");

            if (Number4 == firstNumber || Number4 == secondNumber || Number4 == thirdNumber || Number4 == fourthNumber || Number4 == fifthNumber || Number4 == sixthNumber)
            {
                System.Console.WriteLine("Number 4 (" + fourthNumber + ") is correct");
            }
            else
            {
                Console.WriteLine("Your fourth Number is wrong");
            }

            System.Console.WriteLine("");

            if (Number5 == firstNumber || Number5 == secondNumber || Number5 == thirdNumber || Number5 == fourthNumber || Number5 == fifthNumber || Number5 == sixthNumber)
            {
                System.Console.WriteLine("Number 5 (" + fifthNumber + ") is correct");
            }
            else
            {
                Console.WriteLine("Your fifth Number is wrong");
            }

            System.Console.WriteLine("");

            if (Number6 == firstNumber || Number6 == secondNumber || Number6 == thirdNumber || Number6 == fourthNumber || Number6 == fifthNumber || Number6 == sixthNumber)
            {
                System.Console.WriteLine("Number 6 (" + sixthNumber + ") is correct");
            }
            else
            {
                Console.WriteLine("Your sixth Number is wrong");
            }



            Console.ReadKey();
        }
    }
    
}
