using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lift
{
    class Program
    {
        static bool[] floors = new bool[11];
        static bool upwardDirection = true;
        static int currentFloor = 0;
        static void Main(string[] args)
        {                               
            while(true)
            {
                Console.WriteLine("Enter the floor you want to go to?");

                int input = int.Parse(Console.ReadLine());
                if(input > floors.Length)
                    Console.WriteLine("Invalid floor entered please try again");
                if (input > currentFloor)
                    upwardDirection = true;
                else
                    upwardDirection = false;
                liftRun(input);
            }
        }
        static void liftRun(int floor)
        {
            floors[floor] = true;
            if (upwardDirection)
                moveUpwards();
            else
                moveDownwards();

        }
        static void moveUpwards()
        {
            for (int i = currentFloor; i < floors.Length; i++)
            {
                Thread.Sleep(1000);
                if (floors[i])
                {
                    currentFloor = i;
                    floors[i] = false;
                    Console.WriteLine($"Reached floor {i}");                    
                    Console.WriteLine($"Stopped");
                    Thread.Sleep(2000);
                    Console.WriteLine("Opening doors");
                    Thread.Sleep(2000);
                    Console.WriteLine("Closing doors");
                    Thread.Sleep(2000);
                    break;
                }               
                if (currentFloor == i)
                    Console.WriteLine($"At floor {i}");
                else
                Console.WriteLine($"Reached floor {i}");
            }            
        }
        static void moveDownwards()
        {
            for (int i = currentFloor; i >= 0; i--)
            {
                Thread.Sleep(1000);
                if (floors[i])
                {
                    currentFloor = i;
                    floors[i] = false;                    
                    Console.WriteLine($"Reached floor {i}");
                    Console.WriteLine($"Stopped");
                    Thread.Sleep(2000);
                    Console.WriteLine("Opening doors");
                    Thread.Sleep(2000);
                    Console.WriteLine("Closing doors");
                    Thread.Sleep(2000);
                    break;
                }
                
                if(currentFloor == i)
                    Console.WriteLine($"At floor {i}");
                else
                    Console.WriteLine($"Reached floor {i}");
            }            
        }
    }
}
