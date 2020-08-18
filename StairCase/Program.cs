using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StairCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Staircase(3);

            Console.ReadKey();
        }

        static void Staircase(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for(int j = n; j >0; j--)
                {
                    if (j <= i)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(' ');
                    }          
                }
                Console.WriteLine();
            }
        }
    }
}
