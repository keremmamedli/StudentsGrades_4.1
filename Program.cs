using System;
using System.Threading.Channels;

namespace StudentGrade_4._1_
{
    static class StaticsHelper
    {
        public static double GetAverageGrade(string[] studentNames, double[] grades)
        {
            double count = 0;
            for (int i = 0; i < grades.Length; i++)
            {
                count += grades[i];
            }
            double res = count / grades.Length;
            return res;
        }
        public static double GetLowestGrade(string[] studentNames, double[] grades)
        {
            double min = grades[0];
            for(int i = 0;i < grades.Length; i++)
            {
                if (grades[i] < min)
                {
                    min = grades[i];
                }
            }
            return min;
        }
        public static double GetHighestGrade(string[] studentNames, double[] grades)
        {
            double max = grades[0];
            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i] > max)
                {
                    max = grades[i];
                }
            }
            return max;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter students count: ");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] studentNames = new string[n];
            double[] grades = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter student name: ");
                studentNames[i] = Console.ReadLine();

                Console.WriteLine("Enter grade: ");
                grades[i] = Convert.ToDouble(Console.ReadLine());
            }
            double averageGrade = StaticsHelper.GetAverageGrade(studentNames, grades);
            Console.WriteLine("Average grade: " + averageGrade);

            double minGrade = StaticsHelper.GetLowestGrade(studentNames, grades);
            Console.WriteLine("The lowest grade is: " + minGrade  );

            double maxGrade = StaticsHelper.GetHighestGrade(studentNames, grades);
            Console.WriteLine("The highest grade is: " + maxGrade);
        }
    }
}
