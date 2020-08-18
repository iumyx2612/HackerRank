using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingBook
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int p = Convert.ToInt32(Console.ReadLine());

            int result = pageCount(n, p);

            Console.WriteLine(result);
            Console.ReadKey();
        }

        static int pageCount(int n, int p)
        {
            int starting = (p - 0) / 2;
            if (p % 2 == 1)
            {
                p -= 1;
            }
            int end = (n - p) / 2;
            if(starting>end)
            {
                return end;
            }
            else
            {
                return starting;
            }
            
        }
    }
}
