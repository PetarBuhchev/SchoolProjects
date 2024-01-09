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
            const double Pi = 3.1415;
            const int StudentsCount = 27;
            const string Error = "Грешка при компилиране";
            Console.WriteLine(Student.grades.average);//average
            Console.WriteLine((int)Student.grades.average);//4
            Console.WriteLine((Student.grades)4);//average
        }
    }
}
