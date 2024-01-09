using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritansPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee()
            {
                Name = "Ivan",
                Position = "PR",
                Salary = 1500
            };
            Manager manager = new Manager()
            {
                Name = "Maria",
                Position = "Office Manager",
                Salary = 2000,
                Department = "Administration"
            };

            manager.PrintManagerInformation();
        }
    }
}
