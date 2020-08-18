using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusMinus
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            PlusMinus(arr);
            Console.ReadKey();
        }

        static void PlusMinus(int[] arr)
        {
            int posNumber = 0;
            int negNumber = 0;
            int zeros = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0 )
                {
                    zeros++;
                }
                else if (arr[i] > 0)
                {
                    posNumber++;
                }
                else if(arr[i] < 0)
                {
                    negNumber++;
                }
            }
            Console.WriteLine((double)posNumber / (arr.Length));
            Console.WriteLine((double)negNumber / (arr.Length));
            Console.WriteLine((double)zeros / (arr.Length));
        }
    }
}
