using System;
using System.Security.Cryptography.X509Certificates;

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

        public static double CalculateAverage(Grade[] grades, out int avg)
        {
            if (grades == null || grades.Length == 0)
                throw new ArgumentException("Grades cannot be null or empty.");

            int sum = 0; // Declare and initialize 'sum' here  
            foreach( double grade in grades) //loop through each grade in the array
            {
                sum += grade.Value;// add the value of each grade to the sum
            }
            avg = sum / grades.Length;
            // Calculate the average by dividing the sum by the number of grades
            return avg;
        }

        public static void PrintReport(Grade[] grades)
        {
            if (grades == null || grades.Length == 0)
                throw new ArgumentException("Grades cannot be null or empty.");
            int average = CalculateAverage(grades);
            string letterGrade = GetLetterGrade(average);
            Console.WriteLine("Your average is: " + average);
            Console.WriteLine("Your grade is: " + letterGrade);
        }

    }
}