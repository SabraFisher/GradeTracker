using System;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeTracker
{
    public static class GradeLogic
    {
        public static string GetLetterGrade(int grade)
        {
            if (grade < 0 || grade > 100)
                throw new ArgumentOutOfRangeException(nameof(grade), "Grade must be between 0 and 100.");

            switch (grade / 10)
            {
                case 10:
                case 9:
                    return "A";
                case 8:
                    return "B";
                case 7:
                    return "C";
                case 6:
                    return "D";
                default:
                    return "F";
            }
        }

        public static int CalculateAverage(Grade[] grades, out int v)
        {
            if (grades == null || grades.Length == 0)
                throw new ArgumentException("Grades cannot be null or empty.");

            int sum = 0; // Declare and initialize 'sum' here  
            foreach (Grade grade in grades) // Corrected foreach loop with type and identifier
            {
                sum += grade.Value; // Add the value of each grade to the sum
            }
            v = sum / grades.Length;
            // Calculate the average by dividing the sum by the number of grades
            return v;
        }
    }
}