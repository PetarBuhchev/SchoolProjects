using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseEncapsulation
{
    internal class Calendar
    {
        public const int Months = 12;
        public const int Weeks = 52;
        public const int Year = 2024;
        public const int Days = Year % 4 == 0 ? 366 : 365;
    }
}
