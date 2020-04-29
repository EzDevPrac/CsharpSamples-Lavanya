using System;
using System.Collections.Generic;
using System.Text;

namespace PuzzleUsingFacadePattern
{
    public class GetInputData
    {
        public static int[]  CreateArray()
        {
			int[] arr = new int[6];
			Console.WriteLine("enter the values ");
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = int.Parse(Console.ReadLine());

			}
			return arr;
		}
		public static int GetSumValue()
		{
			Console.WriteLine("enter the Number for finding pair");
			int sum = int.Parse(Console.ReadLine());
			return sum;
		}

	}
}
