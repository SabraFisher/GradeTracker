using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace GradeTracker
{
    public interface IGrades
    {
        static Grade[] GetGradesFromUser(out Grade[] grades)
        {
            Console.WriteLine("Welcome To Grade Tracker!");

            grades = new Grade[5]; // Initialize grades array with 5 elements

            while (true)
            {
                try
                {
                    Console.WriteLine("Please enter 5 valid grades from 1-100 separated by a space:");
                    string input = Console.ReadLine();
                    string[] parts = input.Split(' ');

                    if (parts.Length != 5)
                    {
                        throw new ArgumentException("You must enter exactly 5 grades.");
                    }

                    for (int i = 0; i < 5; i++)
                    {
                        if (!int.TryParse(parts[i], out int value) || value < 1 || value > 100)
                        {
                            throw new ArgumentException($"Invalid grade input: {parts[i]}. Grades must be integers between 1 and 100.");
                        }
                        grades[i] = new Grade { Value = value };
                    }

                    return grades; // Return grades after successful parsing
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Invalid input format. Please try again.");
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("Input value is out of range. Please try again.");
                }
            }
        }

        void CalculateAverage();

        string GetLetterGrade(int grade);

        static void PrintReport(Grade[] grades)
        {
            Console.WriteLine("Grade Report:");

            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i].Value < 0 || grades[i].Value > 100)
                {
                    Console.WriteLine($"Grade {i + 1} is invalid: {grades[i].Value}. Must be between 0 and 100.");
                    Console.WriteLine($"Please re-enter valid grade for Grade {i + 1}.");
                }
            }

            // Assuming GetLetterGrade is implemented elsewhere
            // string letterGrade = GetLetterGrade(grades[i]);
            // Console.WriteLine("Your average is: " + v);
            // Console.WriteLine("Your grade is: " + letterGrade);
        }
    }
        }

        void CalculateAverage();

        string GetLetterGrade(int grade);

        public static void PrintReport(Grade[] grades)
        {
            Console.WriteLine("Grade Report:");

            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i].Value < 0 || grades[i].Value > 100)
                {
                    Console.WriteLine($"Grade {i + 1} is invalid: {grades[i].Value}. Must be between 0 and 100.");
                    Console.Write($"Please re-enter valid grade for Grade {i + 1}.");
                }
            }
            // Assuming GetLetterGrade is implemented elsewhere  
            // string letterGrade = GetLetterGrade(grades[i]);  
            // Console.WriteLine("Your average is: " + v);  
            // Console.WriteLine("Your grade is: " + letterGrade);  
        }
    }
}
