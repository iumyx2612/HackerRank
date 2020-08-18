using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakingRecords
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        static int[] breakingRecords(int[] scores)
        {
            int highest = scores[0];
            int lowest = scores[0];
            int highestCount = 0;
            int lowestCount = 0;
            for (int i = 1; i < scores.Length; i++)
            {
                if(scores[i] > highest)
                {
                    highest = scores[i];
                    highestCount++;
                }
                if(scores[i] < lowest)
                {
                    lowest = scores[i];
                    lowestCount++;
                }
            }
            int[] result = new int[2];
            result[0] = highestCount;
            result[1] = lowestCount;
            return result;
        }
    }
}
