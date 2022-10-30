using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChefMay_Challenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            //A 2d array
            string[,] board = new string[3, 3];

            int testCases = int.Parse(Console.ReadLine());

            while(testCases-- > 0)
            {               
                for(int i = 0; i < 3; i++)
                {
                    string input = Console.ReadLine();

                    for(int j = 0; j < 3; j++)
                    {
                        board[i, j] = input[j].ToString();
                    }                    
                }
                //printBoard(board);
            }
            
            //Console.ReadLine();
        }

        static void printBoard(string[,] boared)
        {
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write(boared[i,j] + " ");
                }
                Console.WriteLine();
            }
        }


        static void printResult(string[,] boared)
        {
            //position is reachable
            

        }
        //0 1 2
        //3 4 5
        //6 7 8
        static bool thereIsWinner(string[,] boared)
        {            
            if(boared[0,0] == boared[0,1] && boared[0,1] == boared[0,2])
            {

            }
        }

    }
}
