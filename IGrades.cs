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
        static Grade[] GetGradesFromUser(out Grade[] grades)
        {
            Console.WriteLine("Welcome To Grade Tracker!");

            grades = new Grade[]; // Initialize grades array with 5 elements

            while (true)
            {

                try
                {
                    Console.WriteLine("Please enter 5 valid grades from 1-100 separated by a space:");
                    string input = Console.ReadLine();
                    string[] parts = input.Split(' ');
                    if (int.TryParse(parts[i], out int gradeValue) && gradeValue >= 0 && gradeValue <= 100)
                    {
                        int grades[i] = new Grade grade;

                    }
                    else
                    {
                        Console.WriteLine($"Invalid grade '{parts[i]}'. Please enter grades between 0 and 100.");
                        continue; // Skip to the next iteration to re-enter grades
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
                    Console.WriteLine("Please re-enter the grades.");
                    continue;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An unexpected error occurred: " + ex.Message);
                    Console.WriteLine("Please re-enter the grades.");
                    continue; // Continue the loop to re-enter grades
                }
                // Recursive call to get grades again
                finally
                {
                    if (grades.Length == 5 && grades.All(g => g.Value >= 0 && g.Value <= 100))
                    {
                        Grade[] gradesArray = new Grade[5];
                        for (int i = 0; i < parts.Length && i < 5; i++)
                        {
                            if (int.TryParse(parts[i], out int gradeValue) && gradeValue >= 0 && gradeValue <= 100)
                            {
                                gradesArray[i] = new Grade { Value = gradeValue };
                            }
                            else
                            {
                                Console.WriteLine($"Invalid grade '{parts[i]}'. Please enter grades between 0 and 100.");
                                continue; // Skip to the next iteration to re-enter grades
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid grades entered. Please try again.");
                        // Continue the loop to re-enter grades
                    }
                    Console.WriteLine("Thank you for using Grade Tracker!");
                    return grades; // Return the grades array
                }

            }
        }

        



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
