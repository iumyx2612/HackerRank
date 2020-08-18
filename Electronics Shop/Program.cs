using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronics_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bnm = Console.ReadLine().Split(' ');

            int b = Convert.ToInt32(bnm[0]);

            int n = Convert.ToInt32(bnm[1]);

            int m = Convert.ToInt32(bnm[2]);

            int[] keyboards = Array.ConvertAll(Console.ReadLine().Split(' '), keyboardsTemp => Convert.ToInt32(keyboardsTemp))
            ;

            int[] drives = Array.ConvertAll(Console.ReadLine().Split(' '), drivesTemp => Convert.ToInt32(drivesTemp))
            ;
            
            int moneySpent = getMoneySpent(keyboards, drives, b);
            Console.WriteLine(moneySpent);
            Console.ReadKey();
        }
        
        static int getMoneySpent(int[] keyboards, int[] drives , int b)
        {
            int moneySpent = -1;
            for (int i = 0; i < keyboards.Length; i++)
            {
                for (int j = 0; j < drives.Length; j++)
                {
                    if((keyboards[i] + drives[j] > moneySpent) && (keyboards[i] + drives[j] <= b))
                    {
                        moneySpent = keyboards[i] + drives[j];
                    }   
                    else
                    {
                        continue;
                    }
                }
            }
            return moneySpent;
        }
    }
}
