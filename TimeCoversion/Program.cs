using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeCoversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            string result = timeConversion(s);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        static string timeConversion(string s)
        {
            string[] temp = s.Split(':');
            int temp0;
            if(temp[2][2] == 'P')
            {
                temp0 = Convert.ToInt32(temp[0]);
                temp0 += 12;
                if(temp0 == 24)
                {
                    temp0 = 12;
                }
                temp[0] = Convert.ToString(temp0);
            }
            if(temp[2][2] == 'A')
            {
                if(temp[0] == "12")
                {
                    temp[0] = "00";
                }
            }        
            string temp2 = temp[2].Remove(2, 2);
            string result;
            result = temp[0] + ":" + temp[1] + ":" + temp2;
            return result;
        }
    }
}
