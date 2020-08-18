using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingStudents
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public static List<int> GradingStudents(List<int> grades)
        {
            for (int i = 0; i < grades.Count; i++)
            {
                if (grades[i] % 5 == 3 && grades[i] >= 38)
                {
                    grades[i] = grades[i] + 2;
                }
                else if(grades[i] % 5 == 4 && grades[i] >= 38)
                {
                    grades[i] = grades[i] + 1;
                }                
            }
            return grades;
        }
    }
}
