using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfProgrammer
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        static string dayOfProgrammer(int year)
        {
            if (year >= 1700 && year <= 1917)
            {
                if(year % 4 == 0)
                {
                    string result = Convert.ToString(256 - 244) + ".09" + "." + Convert.ToString(year);
                    return result;
                }
                else
                {
                    string result = Convert.ToString(256 - 243) + ".09" + "." + Convert.ToString(year);
                    return result;
                }
            }
            else if (year == 1918)
            {
                string result = Convert.ToString(256 - 230) + ".09" + "." + Convert.ToString(year);
                return result;
            }
            else
            {
                if(year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                {
                    string result = Convert.ToString(256 - 244) + ".09" + "." + Convert.ToString(year);
                    return result;
                }
                else
                {
                    string result = Convert.ToString(256 - 243) + ".09" + "." + Convert.ToString(year);
                    return result;
                }
            }
        }
    }
}
