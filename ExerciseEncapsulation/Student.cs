using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseEncapsulation
{
    internal class Student
    {
        public enum grades { failed = 2, acceptable = 3, average = 4, veryGood = 5, excellent = 6 }
        public static int StudentsCount = 0;
        public string Name { get; set; }
        public int Number { get; set; }
        public double GradeBEL { get; set; }
        public double GradeMath { get; set; }

        public void PrintStudentInformation()
        {
            Console.WriteLine($"Name {this.Name}, ID {this.Number}, GradeBEL {this.GradeBEL}, GradeMath {this.GradeMath}");
        }

        public bool HasIncome()
        {
            if ((this.GradeBEL + this.GradeMath) / 2 >= 5.5)
            {
                return true;
            }
            return false;
        }


        public static double CalculateGrade(Student student)
        {
            return (student.GradeBEL + student.GradeMath) / 2;
        }
    }
}
