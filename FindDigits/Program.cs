using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindDigits
{
    class Program
    {
        static int findDigits(int n)
        {
            int count = 0;
            char[] digitArray = n.ToString().ToCharArray();
            int[] arr = new int[digitArray.Length];
            for (int i = 0; i < digitArray.Length; i++)
            {
                arr[i] = Convert.ToInt32(digitArray[i] - 48);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == 0)
                {
                    continue;
                }
                if (n % arr[i] == 0)
                {
                    count++;
                }
            }
            return count;
        }

        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int result = findDigits(n);

                Console.WriteLine(result);
            }
            Console.ReadKey();
        }
    }
}
