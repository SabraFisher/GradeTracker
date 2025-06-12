using System;
using System.Collections.Generic;
using GradeTracker;


 
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Grade?[]? grades = null; // Initialize grades to null 

            // Placeholder for average and letter grade calculation
            double avg = 0; // Initialize avg to avoid CS0103
            char letter = 'F'; // Initialize letter to avoid CS0103

            IGrades.GetGradesFromUser(out grades); // Get grades from user input
                                            // Output the results
            Console.WriteLine("Your average is: " + avg);
            Console.WriteLine("Your grade is: " + letter);
        }
    }


  