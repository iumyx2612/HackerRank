using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplesAndOranges
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] st = Console.ReadLine().Split(' ');

            int s = Convert.ToInt32(st[0]);

            int t = Convert.ToInt32(st[1]);

            string[] ab = Console.ReadLine().Split(' ');

            int a = Convert.ToInt32(ab[0]);

            int b = Convert.ToInt32(ab[1]);

            string[] mn = Console.ReadLine().Split(' ');

            int m = Convert.ToInt32(mn[0]);

            int n = Convert.ToInt32(mn[1]);

            int[] apples = Array.ConvertAll(Console.ReadLine().Split(' '), applesTemp => Convert.ToInt32(applesTemp))
            ;

            int[] oranges = Array.ConvertAll(Console.ReadLine().Split(' '), orangesTemp => Convert.ToInt32(orangesTemp))
            ;
            countApplesAndOranges(s, t, a, b, apples, oranges);

            Console.ReadKey();
        }

        static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            int[] rangeApples = new int[apples.Length];
            int[] rangeOranges = new int[oranges.Length];
            int appleCounts = 0;
            int orangeCounts = 0;
            for (int i = 0; i < apples.Length; i++)
            {
                rangeApples[i] = apples[i] + a;
            }
            for (int i = 0; i < oranges.Length; i++)
            {
                rangeOranges[i] = oranges[i] + b;
            }
            for (int i = 0; i < rangeApples.Length; i++)
            {
                if (rangeApples[i] >= s && rangeApples[i] <= t)
                {
                    appleCounts++;
                }
            }
            for (int i = 0; i < rangeOranges.Length; i++)
            {
                if (rangeOranges[i] >= s && rangeOranges[i] <= t)
                {
                    orangeCounts++;
                }
            }
            Console.WriteLine(appleCounts);
            Console.WriteLine(orangeCounts);
        }
    }
}
