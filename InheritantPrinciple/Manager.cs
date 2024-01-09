using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritansPrinciple
{
    internal class Manager : Employee
    {
        public string Department { get; set; }
        public void PrintManagerInformation()
        {
            Console.WriteLine($"Name: {this.Name}, Position: {this.Position}, Salary: {this.Salary}, Department {this.Department}");
        }
    }
}
