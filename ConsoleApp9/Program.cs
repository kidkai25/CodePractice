using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCases = int.Parse(Console.ReadLine());

            while (testCases-- > 0)
            {
                List<int> board = new List<int>();
                for (int i = 0; i < 3; i++)
                {
                    string input = Console.ReadLine();

                    foreach (var ch in input)
                    {
                        switch (ch)
                        {
                            case 'X':
                                board.Add(1);
                                break;
                            case 'O':
                                board.Add(2);
                                break;
                            default:
                                board.Add(0);
                                break;
                        }
                    }
                }

                //CALCULATE RESULT
                int result = CalculateResult(board);
                Console.WriteLine(result);
                //Console.ReadLine();
            }
        }

        static int CalculateResult(List<int> board)
        {
            int X = board.Where(x => x == 1).Count();
            int O = board.Where(x => x == 2).Count();
            bool p1won = false;
            bool p2won = false;

            if (board[0] == board[1] && board[1] == board[2] && board[0] == 1
                ||
                board[0] == board[3] && board[3] == board[6] && board[0] == 1
                ||
                board[6] == board[7] && board[7] == board[8] && board[6] == 1
                ||
                board[2] == board[5] && board[5] == board[8] && board[2] == 1
                ||
                board[0] == board[4] && board[4] == board[8] && board[0] == 1
                ||
                board[2] == board[4] && board[4] == board[6] && board[2] == 1
                ||
                board[3] == board[4] && board[4] == board[5] && board[3] == 1
                )
            {
                p1won = true;
            }
            if ((board[0] == board[1] && board[1] == board[2] && board[0] == 2
                ||
                board[0] == board[3] && board[3] == board[6]  && board[0] == 2
                ||
                board[6] == board[7] && board[7] == board[8]  && board[6] == 2
                ||
                board[2] == board[5] && board[5] == board[8]  && board[2] == 2
                ||
                board[0] == board[4] && board[4] == board[8]  && board[0] == 2
                ||
                board[2] == board[4] && board[4] == board[6]) && board[2] == 2
                ||
                board[3] == board[4] && board[4] == board[5] && board[3] == 2
                )
            {
                p2won = true;
            }
            if (!(p1won || p2won))
            {
                //if filled and no winner
                if (X - O == 1 && (X == 5 && O == 4))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }

            if (p1won && p2won)
                return 3; // Position is not reachable

            else if ((p1won && ((O + 1) == X)) || (p2won && (X == O)))
            {                              
                return 1; //game drawn or one of the players won
            }            
            else                
                return 3;//position unreachable
        }

    }
}
