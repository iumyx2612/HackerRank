using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayCakeCandles
{
    class Program
    {
        static void Main(string[] args)
        {
            int arCount = Convert.ToInt32(Console.ReadLine());
            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));

            Console.ReadKey();
        }

        static int birthdayCakeCandles(int[] ar)
        {
            int max = ar[0];
            int maxCount = 0;
            for (int i = 1; i < ar.Length; i++)
            {
                if(max < ar[i])
                {
                    max = ar[i];
                }
            }
            for (int i = 0; i < ar.Length; i++)
            {
                if(max == ar[i])
                {
                    maxCount++;
                }
            }
            return maxCount;
        }
    }
}
