using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisibleSumPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));

            int result = divisibleSumPairs(n, k, ar);

            Console.WriteLine(result);

            Console.ReadKey();
        }

        static int divisibleSumPairs(int n, int k, int[] ar)
        {
            int pairCount = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                for (int j = i + 1; j < ar.Length; j++)
                {
                    if((ar[i] + ar[j]) % k == 0)
                    {
                        pairCount++;
                    }
                }
            }
            return pairCount;
        }
    }
}
