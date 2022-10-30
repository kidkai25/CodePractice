/*Help code to get started
 * Note that both classes are in the same file for convenience.
 * If the program gets bigger, you should have the classes in separate files as I go through in the movie
 * Then it may be time to set start values ​​as I did.
 * You can also print things in the console in the constructor to see that it "wakes up
 * This code helps the most if you are aiming for grades E and C
 * Higher grades require more independent work */

using System;
using System.Threading;
//Below is the name of the "namespace" - that is, the project.
// Create a new console project with the name "Bussen" so you can copy over all the code straight from this file
namespace Bussen
{
	class Buss
	{
		public int[] passagerare;
		public int antal_passagerare;


		public void Run()
		{
			bool stopRun = false;
			
            while (true)
            {
                Console.WriteLine("Welcome to the awesome Buss-simulator");
                //This is where the menu should be for doing things
                // I recommend switch and case here
                // In the film number 1 for the final project, I create a menu in this way.
                // In addition, I show how to call the methods below via the menu
                // Now start running the code to see that it works before you start the menu.
                // Then build step-by-step and test run the code.
                Console.WriteLine("Select an option to what you would like to do:-");
                Console.WriteLine("Enter '1' to add a passenger");
                Console.WriteLine("Enter '2' to print all the passengers in the bus");
                Console.WriteLine("Enter '3' to calculate total age of all passengers");
				Console.WriteLine("Enter '4' to calculate average age of all passengers");
				Console.WriteLine("Enter '5' to find age");
				Console.WriteLine("Enter '6' to sort the passengers in the bus");
                Console.WriteLine("Enter '7' to exit program");

				string optionSelected = Console.ReadLine();

				switch(optionSelected)
                {
					case "1": add_passenger();
						break;
					case "2": print_buss();
						break;
					case "3":
						{
							int totalAge = 0;
							totalAge = calc_total_age();
							Console.WriteLine($"Total age of passengers is {totalAge}");
						}
						break;
					case "4":
						{
							double averageAge = 0;
							averageAge = calc_average_age();
							Console.WriteLine($"Average age of passengers is {averageAge}");
						}
						break;
					case "5":
						find_age();
						break;
					case "6":
						sort_buss();
						break;
					case "7":
						stopRun = true;
						break;
				    default:
                        Console.WriteLine("Please enter valid option");
						break;
				}

			
				if (stopRun)
                {
                    Console.WriteLine("Exiting...");
					break;
				}
				Thread.Sleep(2000);
			}
        }

		// Methods for the grade E

		public void add_passenger()
		{
            //Add passengers. Here you enter age but any other information.
            // If the bus is full, no passenger can get on
            Console.WriteLine("Enter age of the new passenger");
			int age = int.Parse(Console.ReadLine());
			if (antal_passagerare == (passagerare.Length))
			{
				Console.WriteLine("Can not add more passenger, the bus is full!");
			}
			else
			{
				passagerare[antal_passagerare++] = age;
                Console.WriteLine($"passenger with age {age} added to the bus");
			}
		}

		public void print_buss()
		{
			//Print all values ​​from the vector. So - print all passengers
			for (int i = 0; i < passagerare.Length; i++)
			{
				if(passagerare[i] != 0) { 
				Console.WriteLine(passagerare[i]);
				}
			}
		}

		public int calc_total_age()
		{
			var sum = 0;
			//Calculate the total age.
			// For the code to work to run, this method must be adjusted, or you can temporarily set the method with void
			for (int i = 0; i < passagerare.Length; i++)
			{
				sum += passagerare[i];
			}
			return sum;
		}

		//Methods for the grade C

		public double calc_average_age()
		{
			//Rating C
			// Calculate the average age. Perhaps it is conceivable that this method will return some value other than integers?
			// For the code to work to run, this method must be adjusted, or you can temporarily set the method with void
			double averageAge = 0;
			double sumAge = 0;			

            for (int i = 0; i < passagerare.Length; i++)
            {
				sumAge += passagerare[i];
            }

			averageAge = sumAge / antal_passagerare;
			return averageAge;			
		}

		public int max_age()
		{
			//Rating C
			// produce the passenger with the highest age. This should be done with your own code and is quite tricky.
			// For the code to work to run, this method must be adjusted, or you can temporarily set the method with void
			int maxAge = 0;
			for(int i = 0; i < passagerare.Length; i++)
            {
				if(passagerare[i] > maxAge)
                {
					maxAge = passagerare[i];
                }					
            }
			return maxAge;
		}

		public void find_age()
		{
            //Show all positions with passengers of a certain age
            // You can also search for age limits - for example 55 to 67
            // Rating C
            // Described in the textbook on page 147 and onwards (code example on page 149)
            Console.WriteLine("Enter ages you want to find in bus(keep lower limit and upper limit same to find only exact age)");
			
			Console.WriteLine("Enter lower limit");
			int lowerLimit = int.Parse(Console.ReadLine());

			Console.WriteLine("Enter upper limit");
			int upperLimit = int.Parse(Console.ReadLine());

            for (int i = 0; i < passagerare.Length; i++)
            {
				if(passagerare[i] >= lowerLimit && passagerare[i] <= upperLimit)
                {
                    Console.WriteLine($"Passenger found with {passagerare[i]}");
                }
            }
		}

		public void sort_buss()
		{
            //Sort the bus by age. Keep in mind that you can not have empty positions "in the middle" of the vector.
            // Described in the textbook on page 147 and onwards (code example on page 159)
            // You should be able to sort the vector with bubble sort
            for (int i = 0; i < passagerare.Length; i++)
            {
                for (int j = 0; j < passagerare.Length - 1; j++)
                {					
					if(passagerare[j] > passagerare[j + 1])
                    {
						int temp = passagerare[j];
						passagerare[j] = passagerare[j + 1];
						passagerare[j + 1] = temp;
                    }
                }
            }

		}

		//Methods for the grade A


		public void print_sex()
		{
			//Rating A
			// This method is not necessarily more difficult than other methods but requires the creation of a class for passengers.
			// Print which positions have male and female passengers respectively.
		}
		public void poke()
		{
			//Rating A
			// Which passenger should we poke at?
			// This method is optional if you want to joke about it a bit, but is also good from a learning point of view.
			// This method should call a passenger's method of how they react if you poke at them (eng: poke)
			// As you can read in the project description, this behavior must be based on age and gender.
		}

		public void getting_off()
		{
			//Rating A
			// A passenger can get off
			// This makes it more difficult when entering new passengers (who sit in the first vacant seat)
			// Sorting also gets trickier
			// The most appropriate solution (but perhaps not the most realistic) is for passengers behind the seat ..
			// .. who belonged to the person who left the bus, may move one place.
			// Then there is never any empty space between passengers.
		}
	}

	class Program
	{
		public static void Main(string[] args)
		{
			//Creates an object of the class Bus called minibus 
			// This part of the code can be very confusing. But in such cases, just "write off". var minbuss = new Buss ();
			var minbuss = new Buss();
			minbuss.passagerare = new int[25];
			minbuss.Run();
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}