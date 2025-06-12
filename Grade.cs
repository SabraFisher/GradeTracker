using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace GradeTracker
{
    public struct Grade
    {
        public double Value { get; private set; } // Changed to instance property with private setter  

        public Grade(double value) : this() // Added 'this()' constructor initializer  
        {
            if (value < 0 || value > 100)
                throw new ArgumentOutOfRangeException(nameof(value), "Grade must be between 0 and 100.");
            Value = value;
        }
    }
}
