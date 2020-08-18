using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtopianTree
{
    class Program
    {
        static int utopianTree(int n )
        {
            int initial = 1;
            if(n == 0)
            {
                return 1;
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    if (i % 2 == 1)
                    {
                        initial *= 2;
                    }
                    else if (i % 2 == 0)
                    {
                        initial += 1;
                    }
                }
            }
            return initial;
        }
        static void Main(string[] args)
        {

            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");
            Console.ReadKey();             
        }
    }
}
