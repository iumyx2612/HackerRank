using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocolateFeast
{
    class Program
    {
        static int chocolateFeast(int n, int c, int m)
        {
            int totalchocoBars = n / c;
            int wrappers = n / c;
            while (wrappers >= m)
            {
                int plusChocoBars = wrappers / m;
                totalchocoBars += plusChocoBars;
                wrappers -= plusChocoBars * m;
                wrappers += plusChocoBars;
            }
            return totalchocoBars;
        }

        static void Main(string[] args)
        {
            int n = 6;
            int c = 2;
            int m = 2;
            int result = chocolateFeast(n, c, m);
            Console.WriteLine(result);
        }
    }
}
