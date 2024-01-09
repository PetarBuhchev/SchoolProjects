using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExerciseEncapsulation
{
    internal static class Employee
    {
        
        public static int countEmployees;
        public static double maxSalary;
        public static int minExperience;

        static Employee()
        {
            countEmployees = 0;
            maxSalary = 0;
            minExperience = int.MaxValue;
        }

        public static void NewMaxSalary(double salary)
        {
            if (salary > maxSalary)
            {
                maxSalary = salary;
            }
        }
    }
}
