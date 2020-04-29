using System;
using System.Collections.Generic;

namespace Puzzle_2
{
	class Program
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
		}//end for fun
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

		static void Main(string[] args)
		{
			int[] arr = new int[6];
			Console.WriteLine("enter the values ");
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = int.Parse(Console.ReadLine());

			}
			Console.WriteLine("enter the Number for finding pair");
			int sum = int.Parse(Console.ReadLine());
			findPair3(arr, sum);
		}
	}
}

