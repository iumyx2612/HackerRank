using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Array_Sum
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Nhap so phan tu mang: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap tung phan tu cua mang:");
            string arrayString = Console.ReadLine();
            string[] simpleArray = arrayString.Split(' ');
            while(simpleArray.Length!=n)
            {
                Console.WriteLine("Nhap lai cac phan tu cua mang: ");
                arrayString = Console.ReadLine();
                simpleArray = arrayString.Split(' ');
            }
            int[] arr = new int[n];
            for (int i = 0; i<n;i++)
            {
                arr[i] = Convert.ToInt32(simpleArray[i]);
            }
            Console.Write("Tong cac phan tu trong mang: {0}", SimpleArraySum(arr));
            Console.ReadKey();
        }

        static int SimpleArraySum(int []array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
    }
}
