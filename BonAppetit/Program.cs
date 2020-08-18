using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonAppetit
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nk = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            List<int> bill = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(billTemp => Convert.ToInt32(billTemp)).ToList();

            int b = Convert.ToInt32(Console.ReadLine().Trim());

            bonAppetit(bill, k, b);

            Console.ReadKey();
        }

        static void bonAppetit(List<int> bill, int k, int b)
        {
            int money = 0;
            for (int i = 0; i < bill.Count; i++)
            {
                money += bill[i];
            }
            money -= bill[k];
            money = money / 2;
            if (money != b)
            {
                Console.WriteLine(Convert.ToString(b - money));
            }
            else
            {
                Console.WriteLine("Bon Appetit");
            }
        }
    }
}
