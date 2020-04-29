using System;
using System.Collections.Generic;
using System.Text;

namespace PuzzleUsingFacadePattern
{
    public class Solve
    {
        public void GetSolution()
        {
            int[] arr = GetInputData.CreateArray();
            int sum = GetInputData.GetSumValue();
            Method1.findPair1(arr, sum);
        }

    }
}
