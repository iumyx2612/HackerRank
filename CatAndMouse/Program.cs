using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatAndMouse
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        static string catAndMouse(int x, int y, int z)
        {
            if (Math.Abs(z - x) > Math.Abs(z - y))
            {
                return "Cat B";
            }
            else if (Math.Abs(z - x) < Math.Abs(z - y))
            {
                return "Cat A";
            }
            else
            {
                return "Mouse C";
            }
        }
    }
}
