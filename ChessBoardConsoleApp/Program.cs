using ChessBoardModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardConsoleApp
{
    class Program
    {
        static Board myBoard = new Board(8);
        static void Main(string[] args)
        {
            
            //show the empty chess board
            PrintBoard(myBoard);


            //ask the user for an x and y coordinate where will place the piece
            Cell currentCell = setCurrentCell();
            currentCell.CurrentlyOccupied = true;

            //calculate all legal moves for that piece
            myBoard.MarkNextLegalMoves(currentCell, "knight");
            //print the chess board, use an X for occupied space, use + for legal move, use . for empty cell
            PrintBoard(myBoard);
            Console.ReadLine();
        }

        private static Cell setCurrentCell()
        {
            //get x and y coordinates from the user
            Console.WriteLine("Enter current Row Number:-");
            int currentRow = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter current column Number");
            int currentColumn = int.Parse(Console.ReadLine());

            //myBoard.TheGrid[currentRow, currentColumn].CurrentlyOccupied = true;
            return myBoard.TheGrid[currentRow, currentColumn];
        }

        private static void PrintBoard(Board myBoard)
        {
            //print the chess board to the console. Use X for piece location, use + fro the legal move, use . for empty cell

            for (int i = 0; i < myBoard.Size; i++)
            {
                for (int j = 0; j < myBoard.Size; j++)
                {
                    Cell c = myBoard.TheGrid[i, j];

                    if(c.CurrentlyOccupied ==true)
                    {
                        Console.Write("X");
                    }

                    else if(c.LegalNextMove == true)
                    {
                        Console.Write("+");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("======================");
        }
    }
}
