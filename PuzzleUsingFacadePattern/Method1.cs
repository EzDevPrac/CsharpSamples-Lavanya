using System;
using System.Collections.Generic;
using System.Text;

namespace PuzzleUsingFacadePattern
{
   public class Method1
    {
		public static void findPair1(int[] A, int sum)
		{

			Dictionary<int, int> map = new Dictionary<int, int>();
			int count = 0;

			for (int i = 0; i < A.Length; i++)
			{

				//if complement is already in map, print the pair
				if (map.ContainsKey(sum - A[i]))
				{
					Console.WriteLine("Pair found at " + map.GetValueOrDefault(sum - A[i]) + " and " + i);
					++count;
				}

				map.Add(A[i], i);

			}//end of for
			if (count == 0)
			{
				Console.WriteLine("No pair found");
			}
		}
	}
}
