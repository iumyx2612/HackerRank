using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingValleys
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            string s = Console.ReadLine();

            int result = countingValleys(n, s);

            Console.WriteLine(result);
            Console.ReadKey();
        }

        static int countingValleys(int n, string s)
        {
            char[] steps = s.ToCharArray();
            int lastStep = 0;
            int thisStep = 0;
            int valleyCount = 0;
            for (int i = 0; i < steps.Length; i++) 
            {                
                if(steps[i] == 'D')
                {
                    thisStep--;
                }
                if(steps[i]== 'U')
                {
                    thisStep++;
                }
                if(thisStep < lastStep && lastStep == 0)
                {
                    valleyCount++;
                }
                lastStep = thisStep;
            }
            return valleyCount;
        }
    }
}
