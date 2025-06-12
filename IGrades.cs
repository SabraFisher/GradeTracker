using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeTracker
{
    public interface IGrades : IComparable<IGrades>
    {
        public static Grade[]? GetGradesFromUser(out Grade[]? grades)
        {
            Console.WriteLine("Welcome To Grade Tracker!");

            do
            {
                grades = null; // Reset grades to null before asking for input
                Console.WriteLine("Please enter 5 valid grades (1-100).\nPress space after each grade:");

                try
                {
                    string? input = Console.ReadLine(); // Allow input to be nullable
                    if (string.IsNullOrWhiteSpace(input))
                    {
                        throw new ArgumentException("Input cannot be null or empty.");
                    }

                    string[] parts = input.Split(' ');
                    grades = new Grade[parts.Length];
                    for (int i = 0; i < parts.Length; i++)
                    {
                        if (int.TryParse(parts[i], out int value))
                        {
                            grades[i] = new Grade(value);
                        }
                        else
                        {
                            throw new ArgumentException("Invalid grade input.");
                        }
                    }
                    break; // Exit the loop if parsing is successful
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Please enter valid grades.");
                }
            } while (true);
        }

        void CalculateAverage();

        string GetLetterGrade(int grade);

        void PrintReport();
    }
}
