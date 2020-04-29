using System;
using System.Collections.Generic;
using System.Text;

namespace PuzzleUsingFacadePattern
{
   public class Method3
    {
		public static void findPair3(int[] A, int sum)
		{

			int count = 0;
			//loop until element before the last
			for (int i = 0; i < A.Length - 1; i++)
			{

				//loop until the last element
				for (int j = i + 1; j < A.Length; j++)
				{

					//if given sum is found, print the indexes
					if (A[i] + A[j] == sum)
					{
						Console.WriteLine("Pair found at " + i + " and " + j);
						++count;
					}
				}
			}
			if (count == 0)
			{
				Console.WriteLine("No pairFound");
			}
		}//End of

	}
}
