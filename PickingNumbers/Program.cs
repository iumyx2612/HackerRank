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
            Console.WriteLine();
            int count = 1;
            for (int i = 0; i < a.Count - 1; i++)
            {
                for (int j = i + 1; j < a.Count - 1; j++)
                {
                    if (Math.Abs(a[i] - a[j]) <= 1) 
                    {
                        if(Math.Abs(a[j] - a[j+1]) <= 1)
                        {
                            if(Math.Abs(j+1 - i) > count)
                            {
                                if (i == 0)
                                {
                                    count = j + 1 - i;
                                }
                                else if (i != 0)
                                {
                                    count = j + 1 - i + 1;
                                }
                            }
                        }
                    }
                    else
                    {
                        break;
                    } 
                }
            }
            return count;            
        }
    }
}
