using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace GradeTracker
{
    public struct Grade(double value)
    {
        private int value = value;

        public static int Value { get; set; } // Removed the private setter to fix S1144  
    }
}
