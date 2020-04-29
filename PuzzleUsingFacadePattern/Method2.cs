using System;
using System.Collections.Generic;
using System.Text;

namespace PuzzleUsingFacadePattern
{
   public class Method2
    {
		public static void findPair2(int[] A, int sum)
		{
			var watch = System.Diagnostics.Stopwatch.StartNew();
			int count = 0;
			Array.Sort(A); //First sort the array

			int low = 0;
			int high = A.Length - 1;

			while (low < high)
			{
				if (A[low] + A[high] == sum)
				{
					Console.WriteLine("Sum found are " + A[low] + " and " + A[high]);
					low++;
					++count;
				}
				else if (A[low] + A[high] < sum)
				{
					low = low + 1;
				}
				else
				{
					high = high - 1;
				}
			} //end of while loop
			if (count == 0)
			{
				Console.WriteLine("No pair Found");
			}
		}
	}
}
