using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SockMerchant
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
            ;
            int result = sockMerchant(n, ar);

            Console.WriteLine(result);
            Console.ReadKey();
        }

        static int sockMerchant(int n, int[] ar)
        {
            int pairCounts = 0;
            List<int> sockList = new List<int>(n);
            for (int i = 0; i < n; i++)
            {
                sockList.Add(ar[i]);
            }
            sockList.Sort();
            for (int i = 0; i < n - 1 ; i++)
            {
                if(sockList[i] == sockList[i+1])
                {
                    pairCounts++;
                    i++;
                }
            }
            return pairCounts;
        }
    }
}
