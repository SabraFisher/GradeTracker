using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace GradeTracker
{
    public interface IGrades
    {
        static Grade[] GetGradesFromUser(string? input, out Grade[] grades, Grade grade)
        {
            Console.WriteLine("Welcome To Grade Tracker!");

            grades = new Grade[5]; // Initialize grades array with 5 elements

            do
            {
                Console.WriteLine("Please enter 5 valid grades from 1-100 separated by a space:");
                try
                {

                    input = Console.ReadLine();
                    string[] parts = input.Split(' ');
                    while (parts != null)
                    {
                        for (int i = 0; i < parts.Length; i++)
                        {
                            if (!(int.TryParse(parts[i], out int value) || value < 0 || value > 100))
                            {
                                Console.WriteLine($"Invalid grade '{parts[i]}'. Please enter 5 grades between 0 and 100 separated by space: ");
                                GetGradesFromUser(input, out grades,);
                           
                                if (int.TryParse(input, out int grade) && value >= 0 && value <= 100)
                                {
                                    grades[i] = new Grade { Value = value };
                                }
                                else
                                {
                                    Console.WriteLine($"Invalid grade '{parts[i]}'. Please enter grades between 0 and 100.");
                                    ; // Skip to the next iteration to re-enter grades
                                }
                            }
                        }
                    }
                    }

                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Please re-enter the grades.");
                    continue;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Invalid input format. Please try again.");
                    continue;
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("Input value is out of range. Please try again.");
                    Console.WriteLine("Please re-enter the 5 grades seperated by a space.");
                    continue;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An unexpected error occurred: " + ex.Message);
                    Console.WriteLine("Please re-enter the 5 grades seperated by a space.");
                    continue; // Continue the loop to re-enter grades
                }

                finally
                {
                    if (grades.Length == 5 && grades.All(g => g.Value >= 0 && g.Value <= 100))
                    {



                    else
                        {
                            Console.WriteLine("Invalid grades entered. Please try again.");
                            // Continue the loop to re-enter grades
                        }
                        Console.WriteLine("Thank you for using Grade Tracker!");
                    }
                    return grades;

                }
                while (true) ;
            }
    } }

        



        static string PrintReport(Grade[] grades)
        {
            Console.WriteLine("-------------  Grade Report   ---------------:");
            
            if (grades.Length > 0 && grades != null) 
            {
                for (int i = 0; i < grades.Length; i++)
                {
                    Console.WriteLine($" Assignment {i + 1}: {grades[i].Value}");

                    Console.WriteLine("Your average grade is: " + GradeLogic.CalculateAverage(grades) + " percent.");
                    Console.WriteLine("Your final letter grade is: " + GradeLogic.GetLetterGrade(grades[i].Value));
                }
            }
            
        }
    }
}
