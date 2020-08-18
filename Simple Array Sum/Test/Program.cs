using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "32:12:12";
            string[] temp = s.Split(':');
            int s0 = Convert.ToInt32(temp[0]);
            s0 += 12;
            temp[0] = Convert.ToString(s0);
            string result = temp[0] + temp[1] + temp[2];
            Console.WriteLine(result);
            Console.ReadKey();
        }    
              
        static void bubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
                for (int j = 0; j < arr.Length - i - 1; j++)
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
        }
    }
}
