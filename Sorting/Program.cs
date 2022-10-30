using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
			List<int> l = new List<int> { 0, 1, 2, 0, 1, 2 };
            sortColors(l).ForEach(Console.WriteLine);
			Console.ReadLine();
		}
		public static List<int> sortColors(List<int> A)
		{
			int zero = 0;
			int two = A.Count - 1;

			for (int i = 0; i <= two;)
			{
				if (A[i] == 0)
				{
					int temp = A[zero];
					A[zero] = 0;
					A[i] = temp;
					zero++;
					i++;
				}
				else if (A[i] == 2)
				{
					int temp = A[two];
					A[two] = 2;
					A[i] = temp;
					two--;
				}
				else
				{
					i++;
				}
			}
			return A;
		}
	}
}
