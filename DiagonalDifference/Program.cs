using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = diagonalDifference(arr);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        public static int diagonalDifference(List<List<int>> arr)
        {
            int primaryDiagonal = 0;
            int secondaryDiagonal = 0;
            for (int i = 0; i < arr[1].Count; i++) 
            {
                primaryDiagonal += arr[i][i];
            }
            for (int i = 0, j = arr[1].Count - 1; i < arr[1].Count; i++, j--)
            {
                secondaryDiagonal += arr[i][j];
            }
            int result = Math.Abs(primaryDiagonal - secondaryDiagonal);
            return result;
        }
    }
}
