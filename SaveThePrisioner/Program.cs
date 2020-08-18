using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveThePrisioner
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] nms = Console.ReadLine().Split(' ');

                int n = Convert.ToInt32(nms[0]);

                int m = Convert.ToInt32(nms[1]);

                int s = Convert.ToInt32(nms[2]);

                int result = saveThePrisoner(n, m, s);

                Console.WriteLine(result);
            }

            Console.ReadKey();
        }
                
            static int saveThePrisoner(int n, int m, int s)
        {
            int divide = m / n;
            int candiesLeft = m - n * divide;
            return s + candiesLeft - 1 ;
        }
    }
}
