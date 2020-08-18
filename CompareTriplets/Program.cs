using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace CompareTriplets
{
    class Program
    {
        static void Main(string[] args)
        {         
            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();
            List<int> result = compareTriplets(a, b);
            
            Console.ReadKey();
        }

        static List<int> compareTriplets(List<int> a, List<int> b)
        {
            List<int> result = new List<int>(2);
            int aCount = 0;
            int bCount = 0;
            for(int i = 0; i < a.Count; i++)
            {
                if(a[i] > b[i])
                {
                    aCount++;
                }
                else if(a[i] < b[i])
                {
                    bCount++;
                }
                else if(a[i] == b[i])
                {
                    continue;
                }
            }
            result.Insert(0, aCount);
            result.Insert(1, bCount);
            return result;
        }
    }
}
