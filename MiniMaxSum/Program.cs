using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            MiniMaxSum(arr);
            Console.ReadKey();
        }        

        static void MiniMaxSum(int [] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if(arr[j]>arr[j+1])
                    {
                        int temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            long maxSum = 0;
            long minSum = 0;
            for(int i = 0; i < arr.Length - 1; i++)
            {
                minSum += arr[i];
            }
            for (int i = 1; i < arr.Length; i++)
            {
                maxSum += arr[i];
            }
            Console.WriteLine("{0} {1}", minSum, maxSum);
        }
    }
}
