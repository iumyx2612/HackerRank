using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignerPdfViewer
{
    class Program
    {
        static int designerPdfViewer(int[] h, string word)
        {
            char[] wordArray = word.ToCharArray();
            int[] wordintArray = new int[27];
            for (int j = 0; j < wordArray.Length; j++)
            {
                wordintArray[Convert.ToInt32(wordArray[j]) - 97]++;
            }
            List<int> number = new List<int>();
            for (int i = 0; i < wordintArray.Length; i++)
            {
                if(wordintArray[i] != 0)
                {
                    number.Add(h[i]);
                }
            }
            int max = number[0];
            for (int i = 0; i < number.Count; i++)
            {
                if (number[i] > max)
                {
                    max = number[i];
                }
            }
            return max * wordArray.Length;
        }
        static void Main(string[] args)
        {
            
        }
    }
}
