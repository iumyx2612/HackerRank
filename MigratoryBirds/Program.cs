using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigratoryBirds
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            int result = migratoryBirds(arr);

            Console.WriteLine(result);

            Console.ReadKey();
        }

        static int migratoryBirds(List<int> arr)
        {
            int[] type = new int[arr.Max() + 1];
            foreach (int item in arr)
            {
                type[item]++;  
            }
            int m = 0; // vi tri max
            for (int i = 0; i < type.Length; i++)
            {
                if (type[m] < type[i]) { m = i; }
            }
            return m;
        }
    }
}
