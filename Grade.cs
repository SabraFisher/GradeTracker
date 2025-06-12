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
        
        public Grade()
        {
            if (value < 0 || value > 100)
                throw new ArgumentOutOfRangeException("Grade must be between 0 and 100.");
            _value = value;
        }
        
        public override bool Equals([NotNullWhen(true)] object? obj)
        {
            return base.Equals(obj);
        }

        
    }
}
