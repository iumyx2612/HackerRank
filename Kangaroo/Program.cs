using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangaroo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] x1V1X2V2 = Console.ReadLine().Split(' ');

            int x1 = Convert.ToInt32(x1V1X2V2[0]);

            int v1 = Convert.ToInt32(x1V1X2V2[1]);

            int x2 = Convert.ToInt32(x1V1X2V2[2]);

            int v2 = Convert.ToInt32(x1V1X2V2[3]);

            string result = Kangaroo(x1, v1, x2, v2);

            Console.WriteLine(result);

            Console.ReadKey();
        }

        static string Kangaroo(int x1, int v1, int x2, int v2)
        {
            string[] result = { "YES", "NO" };
            double distance = x2 - x1;
            double velo = v1 - v2;
            double d = distance / velo;
            if (Math.Abs(d) % 1 == 0 && d >= 0)
            {
                return result[0];
            }
            else
            {
                return result[1];
            }
        }

    }
}
