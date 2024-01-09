using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Student s2 = new Student();
            Student s3 = new Student();
            s1.PrintStudentInformation();
            Console.WriteLine(s1.HasIncome() ? "Получава" : "Не получава");

            double grade = Student.CalculateGrade(s1);
            Console.WriteLine(Student.StudentsCount);
        }
    }
}
