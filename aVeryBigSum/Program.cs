using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aVeryBigSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so phan tu: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap cac phan tu: ");
            string _array = Console.ReadLine();
            string[] _ar = _array.Split(' ');
            while(_ar.Length!=n)
            {
                Console.WriteLine("Nhap lai mang: ");
                _array = Console.ReadLine();
                _ar = _array.Split(' ');
            }
            long[] bigSum = new long[n];
            for(int i = 0; i<_ar.Length; i++)
            {
                bigSum[i] = Convert.ToInt32(_ar[i]);
            }
            long result = AVeryBigSum(bigSum);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        static long AVeryBigSum(long[] ar)
        {
            long sum = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                sum += ar[i];
            }
            return sum;
        }
    }
}
