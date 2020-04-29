using System;

namespace Puzzle_3
{
	class Program
	{
        static void spiralPrint(int m, int n, int[,] a)
        {
            int i, k = 0, l = 0;
            /* k - starting row index 
            m - ending row index 
            l - starting column index 
            n - ending column index 
            i - iterator 
            */

            while (k < m && l < n)
            {
                // Print the first row  
                // from the remaining rows 
                for (i = l; i < n; ++i)
                {
                    Console.Write(a[k, i] + " ");
                }
                k++;

                // Print the last column from the 
                // remaining columns 
                for (i = k; i < m; ++i)
                {
                    Console.Write(a[i, n - 1] + " ");
                }
                n--;

                // Print the last row from  
                // the remaining rows  
                if (k < m)
                {
                    for (i = n - 1; i >= l; --i)
                    {
                        Console.Write(a[m - 1, i] + " ");
                    }
                    m--;
                }

                // Print the first column from  
                // the remaining columns 
                if (l < n)
                {
                    for (i = m - 1; i >= k; --i)
                    {
                        Console.Write(a[i, l] + " ");
                    }
                    l++;
                }
            }
        }

        public static void Main()
        {
            int M = 3;
            int N = 3;
            int[,] a = {  {1, 2, 3},
                          {8, 9, 4},
                          {7, 6, 5} 
            };
            spiralPrint(M, N, a);
        }
    }
}
