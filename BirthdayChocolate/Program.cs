using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayChocolate
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

            string[] dm = Console.ReadLine().TrimEnd().Split(' ');

            int d = Convert.ToInt32(dm[0]);

            int m = Convert.ToInt32(dm[1]);

            int result = Birthday(s, d, m);
            Console.WriteLine(result);

            Console.ReadKey();
        }

        static int Birthday(List<int> s, int d, int m)
        {
            int sum = 0;
            int count = 0;
            for (int i = 0; i <= s.Count - m; i++)
            {
                if (s.Count < m)
                {
                    count = 0;
                }
                else if (s.Count >= m)
                {
                    for (int j = i; j < i + m; j++)
                    {
                        sum += s[j];
                    }
                    if (sum == d)
                    {
                        count++;
                    }
                }
                sum = 0;
            }
            return count;
        }
    }
}
