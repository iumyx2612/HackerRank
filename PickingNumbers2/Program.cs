using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            int result = pickingNumbers(a);

            Console.WriteLine(result);
            Console.ReadKey();

        }
        static int pickingNumbers(List<int> a)
        {
            a.Sort();
            foreach (int item in a)
            {
                Console.Write(item + " ");
            }
            int min = a[0];
            int max = a[a.Count - 1];
            Console.WriteLine();
            List<List<int>> subarrays = new List<List<int>>();
            for (int i = 0; i < a.Count - 1; i++)
            {
                for (int j = i + 1; j < a.Count; j++)
                {
                    if()
                }
            }
 
        }
    }
}
