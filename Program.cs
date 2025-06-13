using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeTracker;
{ 
    internal static class Program
    {
        static void Main(string[] args)
        {

            Grade[] grades; // Initialize grades to null 

            // Placeholder for average and letter grade calculation
            int v = 0; // Initialize avg to avoid CS0103
             // Initialize letter to avoid CS0103
            do
            {
               IGrades.GetGradesFromUser(out grades);
               IGrades.PrintReport(grades);

            } while (grades != null && grades.Length < 5); // Get grades from user input
        }
    }



  